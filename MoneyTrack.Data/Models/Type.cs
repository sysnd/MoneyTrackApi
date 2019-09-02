using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MoneyTrack.Data.Models
{
    public class Type : BaseModel
    {
        public string Name { get; set; }

    }
}
