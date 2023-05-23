
namespace jsonCRUD
{
    public  class FoodGeneralInfo
    {
        public string Url { get; set; }
        public string ItalianName { get; set;}
        public string Category { get; set; }
        public string FoodCode { get; set; }
        public string ScientificName { get; set; }
        public string EnglishName { get; set; }
        public string Information { get; set; }
        public string NumberOfSamples { get; set; }
        public string EatablePartpercentage { get; set; }
        public string Portion { get; set; }
        public List<Nutrition> Nutritions { get; set; }
        public List<Langual> LangualCodes { get; set; }
        public List<Chart> ChatData { get; set; }

    }
}
