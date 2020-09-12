using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Vanilly.Server.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }

    public class ItemsDatabaseSettings
    {
        public string ItemsCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
