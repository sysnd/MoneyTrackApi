namespace MoneyTrack.Data.Models
{
    public class Budget : BaseModel
    {
        public Type Type { get; set; }
        public decimal Value { get; set; }
    }
}
