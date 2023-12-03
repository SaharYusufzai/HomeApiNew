using System.ComponentModel.DataAnnotations;

namespace HousePriceAPI.DTOs
{
    public class HousePriceDTOPublic
    {
        [Key] public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string StateName { get; set; }

        public double Jan2023 { get; set; }
        public double Feb2023 { get; set; }
        public double Mar2023 { get; set; }
        public double Apr2023 { get; set; }
        public double May2023 { get; set; }
        public double Jun2023 { get; set; }
        public double Jul2023 { get; set; }
        public double Aug2023 { get; set; }
        public double Sep2023 { get; set; }
        public double Oct2023 { get; set; }



    }
}
