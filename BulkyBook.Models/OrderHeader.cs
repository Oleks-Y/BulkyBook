﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        
        public string ApplicationUserId { get; set; }
        
        [ForeignKey("ApplicationUserID")]
        public ApplicationUser ApplicationUser { get; set; }
        
        [Required] 
        public DateTime OrderDate { get; set; }
        [Required] 
        public DateTime ShippingDate { get; set; }
        [Required] public Double OrderTotal { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        
        public string TransactionId { get; set; }

        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }

    }
}