using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wfDereksWines.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public System.DateTime OrderDate { get; set; }
        [ScaffoldColumn(false)]

        public decimal Total { get; set; }
        [ScaffoldColumn(false)]

        public string PaymentTransactionId { get; set; }
        [ScaffoldColumn(false)]

        public bool HasBeenShipped { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; }
    }
}