﻿using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    public class Business
    {
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool WithinCityLimits { get; set; }
    }
}
