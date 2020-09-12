using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vanilly.Server.Models;

namespace Vanilly.Server.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsRepository _repository;

        public ItemsController(ItemsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize("read:items")]
        public async Task<List<Item>> GetAllItems()
        {
            return await _repository.GetAllItemsAsync();
        }

        [HttpGet("{id}")]
        [Authorize("read:items")]
        public Task<Item> GetItemById(Guid id)
        {
            return _repository.GetItemByIdAsync(id);
        }

        [HttpPost]
        [Authorize("modify:items")]
        public Task<Item> CreateItem([Required, StringLength(20), FromQuery] string name, [Required, FromQuery] DateTime dueDate)
        {
            return _repository.CreateItemAsync(name, dueDate);
        }
    }
}
