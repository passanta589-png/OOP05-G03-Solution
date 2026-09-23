using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05G03
{
    internal partial class Shipment
    {
        public string TrackingCode { get; set; }
        public string ShipmentType { get; set; }
        public double Weight { get; set; }
        public DeliveryAddress Address { get; set; }
        public static int TotalShipmentsCreated;
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        public Shipment(string TrackingCode, string shipmentType, double Weight, string addressString)
        {
            this.TrackingCode = TrackingCode;
            this.ShipmentType = shipmentType;
            this.Weight = Weight;
            this.Address = new DeliveryAddress(addressString);
        }
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        public Shipment CopyShipment()
        {
            return this;
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Address = this.Address.copy();
            return copy;
        }
    }
}
