using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EventsProtocolsDelegates.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Image { get; set; }
        public string Country { get; set; }
        public double Rating { get; set; }
        public bool IsOnline { get; set; }
    }
}