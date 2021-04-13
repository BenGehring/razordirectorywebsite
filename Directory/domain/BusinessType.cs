using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    public class BusinessType
    {
        public int Id { get; set; }
        public string BusinessTypeName { get; set; }
        public IEnumerable<Business> Businesses { get; set; }
    }
}
