﻿
using System;
using System.Collections.Generic;


namespace ProductOutlook.WebUI.Models
{
    public class ProductCatagory 
    {
        public ProductCatagory()
        {
            Products = new List<Product>();
        }
        public Guid ProductCatagoryId { get; set; }

        public string CatagoryName { get; set; }

        public virtual ICollection <Product>  Products { get; set; }
    }
}