namespace MoneyTrack.Data.Models
{
   public class Income : BaseModel
    {
        public Type Type { get; set; }
        public decimal Value { get; set; }
    }
}
