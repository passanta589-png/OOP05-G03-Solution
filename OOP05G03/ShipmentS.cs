using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05G03
{
    internal partial class Shipment
    {
        public string TrackingStatus { get; set; }

        partial void OnTrackingStatusChanged(string newStatus);

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}
