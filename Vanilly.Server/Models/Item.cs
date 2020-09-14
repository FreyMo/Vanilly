using System;
using System.ComponentModel.DataAnnotations;

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
}
