using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage ="enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="enter first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage ="enter city")]
        public string City { get; set; }

        [Required(ErrorMessage ="enter state")]
        public string State { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}