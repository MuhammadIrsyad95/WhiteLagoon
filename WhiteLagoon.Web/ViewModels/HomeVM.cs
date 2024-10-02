using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Web.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Villa>? VillaList { get; set; }
        public DateOnly CheckinDate { get; set; }
        public DateOnly? CheckoutDate { get;set; }
        public int Nights { get; set; }
    }
}
