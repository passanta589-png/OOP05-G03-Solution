using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05G03
{
    internal class DeliveryAddress
    {
        public string City { get; set; }
        public DeliveryAddress(string city)
        {
            city = city;
        }
        public DeliveryAddress copy()
        {
            return new DeliveryAddress(this.City);
        }
    }
}
