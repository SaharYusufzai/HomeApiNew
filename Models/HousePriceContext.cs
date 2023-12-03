using Microsoft.EntityFrameworkCore;
using HousePriceAPI.DTOs;

namespace HousePriceAPI.Models
{
    public class HousePriceContext :DbContext
    {
      
        public HousePriceContext() { }

        public HousePriceContext(DbContextOptions<HousePriceContext> options) : base(options) { }


        public virtual DbSet<HousePrice> HousePrice { get; set; } = null!;


        public DbSet<HousePriceAPI.DTOs.HousePriceDTOPublic>? HousePriceDTO { get; set; }


       


    }
}
