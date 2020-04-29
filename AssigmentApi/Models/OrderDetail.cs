using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssigmentApi.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

    }
}