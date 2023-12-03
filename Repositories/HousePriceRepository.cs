using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using HousePriceAPI.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace HousePriceAPI.Models
{
    public class HousePriceRepository
    {

        private readonly HousePriceContext _context;

        public HousePriceRepository(HousePriceContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HousePrice>> GetAllItemsAsync()
        {
            return await _context.HousePrice.ToListAsync();
        }

    }
}
