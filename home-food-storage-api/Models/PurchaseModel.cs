namespace home_food_storage_api.Models
{
    public class PurchaseModel
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseCreateDate { get; set; }
        public DateTime PurchaseUpdateDate { get; set; }
        public string PurchasePlace { get; set; }
        public string PurchasePlaceCity { get; set; }
        public List<ItemModel> PurchaseItems { get; set; }
        public string PurchasePaymentMethod { get; set; }
        public decimal PurchaseTotal { get; set; }
    }
}
