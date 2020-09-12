using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DnsClient.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Vanilly.Server.Models;

namespace Vanilly.Server.Controllers
{
    public class ItemsRepository
    {
        private readonly IMongoCollection<Item> _items;

        public ItemsRepository(IOptions<ItemsDatabaseSettings> options, ILogger<ItemsRepository> logger)
        {
            var settings = options.Value;

            logger.LogCritical($"Trying to connecto to '{settings.ConnectionString}'");
            
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _items = database.GetCollection<Item>(settings.ItemsCollectionName);
        }

        public Task<List<Item>> GetAllItemsAsync() => _items.Find(x => true).ToListAsync();

        public Task<Item> GetItemByIdAsync(Guid id) => _items.Find<Item>(i => i.Id == id).FirstOrDefaultAsync();

        public async Task<Item> CreateItemAsync(string name, DateTime dueDate)
        {
            var item = new Item
            {
                Id = Guid.NewGuid(),
                Name = name,
                DueDate = dueDate
            };

            await _items.InsertOneAsync(item);

            return item;
        }

        //public void Update(string id, Book bookIn) =>
        //    _books.ReplaceOne(book => book.Id == id, bookIn);

        //public void Remove(Book bookIn) =>
        //    _books.DeleteOne(book => book.Id == bookIn.Id);

        //public void Remove(string id) =>
        //    _books.DeleteOne(book => book.Id == id);
    }
}
