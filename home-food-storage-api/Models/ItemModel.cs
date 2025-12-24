namespace home_food_storage_api.Models
{
    public class ItemModel
    {
        public int PurchaseId { get; set; }
        public int ItemId { get; set; }
        public string ItemName{ get; set; }
        public string ItemDescription { get; set; }
        public float ItemWeight { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemValue { get; set; }
        public decimal ItemSubtotal { get; set; }
    }
}
