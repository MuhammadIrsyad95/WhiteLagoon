namespace WhiteLagoon.Web.ViewModels
{
    public class RadialBarChartVM
    {
        public decimal TotalCount { get; set; }
        public decimal CountInCurrentMonth { get; set; }
        public bool HasRadioIncreased { get; set; }
        public int[] Series { get; set; }
    }
}
