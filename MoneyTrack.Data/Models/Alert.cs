using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTrack.Data.Models
{
    public class Alert : BaseModel
    {
        public Type Type { get; set; }
        public decimal Value { get; set; }
        public int Percentage { get; set; }
    }
}
