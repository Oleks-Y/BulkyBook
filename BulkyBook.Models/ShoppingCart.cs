﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }
        [Key] public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")] 
        public ApplicationUser ApplicationUser { get; set; }

        public string ProductId { get; set; }
        [ForeignKey("ProductId")] 
        public Product Product { get; set; }
        [Range(1,1000, ErrorMessage = "Please enter Correct value")]
        public int Count { get; set; }

        [NotMapped]
        public double Price { get; set; }

    }
}
