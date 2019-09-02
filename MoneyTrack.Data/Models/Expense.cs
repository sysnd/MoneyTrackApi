using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTrack.Data.Models
{
    public class Expense : BaseModel
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
