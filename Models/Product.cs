using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardManagementSystem.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Interest { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}