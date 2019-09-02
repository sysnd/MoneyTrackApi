using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTrack.Data.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }

    }
}
