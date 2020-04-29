using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssigmentApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<OrderDetail> Products { get; set; }

    }
}