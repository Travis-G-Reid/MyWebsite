namespace MyWebApp
{
    public class Categories
    {
        public List<string> HouseholdItems { get; set; }
        public List<string> CarParts { get; set; }
        public List<string> Electronics { get; set; }
        public List<string> Clothing { get; set; }
        public List<string> OfficeSupplies { get; set; }

        public Categories()
        {
            HouseholdItems = new List<string>();
            CarParts = new List<string>();
            Electronics = new List<string>();
            Clothing = new List<string>();
            OfficeSupplies = new List<string>();
        }
    }
}
