using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entities
{
    public class Customer: IEntity //veritabanında var demek istiyorum

    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
