namespace TMS.Models
{
    public class TaxVM
    {
        public int Id { get; set; }
        public string MunicipalityName = "";
        public string Date = "";
        public string TaxType { get; set; }
        public string TaxAmount { get; set; }
    }
}
