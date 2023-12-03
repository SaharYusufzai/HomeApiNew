using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HousePriceAPI.Models;
using HousePriceAPI.DTOs;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace HousePriceAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class HousePriceController : ControllerBase
    {
        private readonly HousePriceContext _context;

        public HousePriceController(HousePriceContext context)
        {
            _context = context;
        }


        [HttpGet("admin/getHousePrice")]
        public async Task<ActionResult<IEnumerable<HousePriceDTOAdmin>>> GetHouseAllPrices()
        {

            var housePrices = await _context.HousePrice
           .Select(h => new HousePriceDTOAdmin
           {
               RegionID = h.RegionID,
               RegionName = h.RegionName,
               StateName = h.StateName,

               Oct2021 = h.Oct2021,
               Nov2021 = h.Nov2021,
               Dec2021 = h.Dec2021,

               Jan2022 = h.Jan2022,
               Feb2022 = h.Aug2022,
               Mar2022 = h.Sep2022,
               Apr2022 = h.Apr2022,
               May2022 = h.May2022,
               Jun2022 = h.Jun2022,
               Jul2022 = h.Jul2022,
               Aug2022 = h.Aug2022,
               Sep2022 = h.Sep2022,
               Oct2022 = h.Oct2022,
               Nov2022 = h.Nov2022,
               Dec2022 = h.Dec2022,

               Jan2023 = h.Jan2023,
               Feb2023 = h.Aug2023,
               Mar2023 = h.Sep2023,
               Apr2023 = h.Apr2023,
               May2023 = h.May2023,
               Jun2023 = h.Jun2023,
               Jul2023 = h.Jul2023,
               Aug2023 = h.Aug2023,
               Sep2023 = h.Sep2023,
               Oct2023 = h.Oct2023
           })
           .ToListAsync();

            return Ok(housePrices);
        }




        // GET: api/HousePrice
        [HttpGet("public/getHousePrice")]
        public async Task<ActionResult<IEnumerable<HousePriceDTOPublic>>> GetHousePrices()
        {

            var housePrices = await _context.HousePrice
            .Select(hp => new HousePriceDTOPublic
            {
                RegionID = hp.RegionID,
                RegionName = hp.RegionName,
                StateName = hp.StateName,

                Jan2023 = hp.Jan2023,
                Feb2023 = hp.Aug2023,
                Mar2023 = hp.Sep2023,
                Apr2023 = hp.Apr2023,

                May2023 = hp.May2023,
                Jun2023 = hp.Jun2023,
                Jul2023 = hp.Jul2023,

                Aug2023 = hp.Aug2023,
                Sep2023 = hp.Sep2023,
                Oct2023 = hp.Oct2023
            })
            .ToListAsync();

            return Ok(housePrices);



        }


        // GET: api/HousePrice/5
        [HttpGet("public/getHousePrice/{id}")]
        public async Task<ActionResult<HousePriceDTOPublic>> GetPublicHousePrice(int id)
        {

            var housePrice = await _context.HousePrice
            .Where(hp => hp.RegionID == id)
            .Select(hp => new HousePriceDTOPublic
            {
                RegionID = hp.RegionID,
                RegionName = hp.RegionName,
                StateName = hp.StateName,


                Jan2023 = hp.Jan2023,
                Feb2023 = hp.Aug2023,
                Mar2023 = hp.Sep2023,
                Apr2023 = hp.Apr2023,
                May2023 = hp.May2023,
                Jun2023 = hp.Jun2023,
                Jul2023 = hp.Jul2023,
                Aug2023 = hp.Aug2023,
                Sep2023 = hp.Sep2023,
                Oct2023 = hp.Oct2023
            })
            .FirstOrDefaultAsync();


            return Ok(housePrice);


        }












        // GET: api/HousePrice/5
        [HttpGet("admin/getHousePrice/{id}")]
        public async Task<ActionResult<HousePriceDTOAdmin>> GetHousePrice(int id)
        {

            var housePrice = await _context.HousePrice
            .Where(hp => hp.RegionID == id)
            .Select(hp => new HousePriceDTOAdmin
            {
                RegionID = hp.RegionID,
                RegionName = hp.RegionName,
                StateName = hp.StateName,

                Oct2021 = hp.Oct2021,
                Nov2021 = hp.Nov2021,
                Dec2021 = hp.Dec2021,

                Jan2022 = hp.Jan2022,
                Feb2022 = hp.Aug2022,
                Mar2022 = hp.Sep2022,
                Apr2022 = hp.Apr2022,
                May2022 = hp.May2022,
                Jun2022 = hp.Jun2022,
                Jul2022 = hp.Jul2022,
                Aug2022 = hp.Aug2022,
                Sep2022 = hp.Sep2022,
                Oct2022 = hp.Oct2022,
                Nov2022 = hp.Nov2022,
                Dec2022 = hp.Dec2022,

                Jan2023 = hp.Jan2023,
                Feb2023 = hp.Aug2023,
                Mar2023 = hp.Sep2023,
                Apr2023 = hp.Apr2023,
                May2023 = hp.May2023,
                Jun2023 = hp.Jun2023,
                Jul2023 = hp.Jul2023,
                Aug2023 = hp.Aug2023,
                Sep2023 = hp.Sep2023,
                Oct2023 = hp.Oct2023
            })
            .FirstOrDefaultAsync();


            return Ok(housePrice);


        }







        

        // PUT: api/HousePrice/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("admin/editHousePrice/{id}")]
        public async Task<IActionResult> PutHousePrice(int id, HousePriceDTOAdmin h)
        {
            var existingHousePrice = await _context.HousePrice.FindAsync(id);

            existingHousePrice.RegionID = h.RegionID;
            existingHousePrice.RegionName = h.RegionName;
            existingHousePrice.StateName = h.StateName;

            existingHousePrice.Oct2021 = h.Oct2021;
            existingHousePrice.Dec2021 = h.Dec2021;
            existingHousePrice.Oct2021 = h.Oct2021;

            existingHousePrice.Jan2022 = h.Jan2022;
            existingHousePrice.Feb2022 = h.Feb2022;
            existingHousePrice.Mar2022 = h.Mar2022;
            existingHousePrice.Apr2022 = h.Apr2022;
            existingHousePrice.May2022 = h.May2022;
            existingHousePrice.Jun2022 = h.Jun2022;
            existingHousePrice.Jul2022 = h.Jul2022;
            existingHousePrice.Aug2022 = h.Aug2022;
            existingHousePrice.Sep2022 = h.Sep2022;
            existingHousePrice.Oct2022 = h.Oct2022;
            existingHousePrice.Nov2022 = h.Nov2022;
            existingHousePrice.Dec2022 = h.Dec2022;
            
            existingHousePrice.Jan2023 = h.Jan2023;
            existingHousePrice.Feb2023 = h.Feb2023;
            existingHousePrice.Mar2023 = h.Mar2023;
            existingHousePrice.Apr2023 = h.Apr2023;
            existingHousePrice.May2023 = h.May2023;
            existingHousePrice.Jun2023 = h.Jun2023;
            existingHousePrice.Jul2023 = h.Jul2023;
            existingHousePrice.Aug2023 = h.Aug2023;
            existingHousePrice.Sep2023 = h.Sep2023;
            existingHousePrice.Oct2023 = h.Oct2023;


            _context.Entry(existingHousePrice).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var updatedHousePriceDTO = existingHousePrice;

            return Ok(updatedHousePriceDTO);
        }

        // POST: api/HousePrice
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost("admin/addHousePrice")]
        public async Task<ActionResult<HousePriceDTOAdmin>> PostHousePrice(HousePriceDTOAdmin h)
        {

            var newHousePrice = new HousePrice
            {
                RegionID = h.RegionID,
                RegionName = h.RegionName,
                StateName = h.StateName,

                Oct2021 = h.Oct2021,
                Nov2021 = h.Nov2021,
                Dec2021 = h.Dec2021,

                Jan2022 = h.Jan2022,
                Feb2022 = h.Aug2022,
                Mar2022 = h.Sep2022,
                Apr2022 = h.Apr2022,
                May2022 = h.May2022,
                Jun2022 = h.Jun2022,
                Jul2022 = h.Jul2022,
                Aug2022 = h.Aug2022,
                Sep2022 = h.Sep2022,
                Oct2022 = h.Oct2022,
                Nov2022 = h.Nov2022,
                Dec2022 = h.Dec2022,

                Jan2023 = h.Jan2023,
                Feb2023 = h.Aug2023,
                Mar2023 = h.Sep2023,
                Apr2023 = h.Apr2023,
                May2023 = h.May2023,
                Jun2023 = h.Jun2023,
                Jul2023 = h.Jul2023,
                Aug2023 = h.Aug2023,
                Sep2023 = h.Sep2023,
                Oct2023 = h.Oct2023
            };

            _context.HousePrice.Add(newHousePrice);
            await _context.SaveChangesAsync();


            var createdHousePriceDTO = newHousePrice;

            return CreatedAtAction(nameof(GetHousePrice), new { id = createdHousePriceDTO.RegionID }, createdHousePriceDTO);


        }

        // DELETE: api/HousePrice/5
        [HttpDelete("admin/deleteHousePrice/{id}")]
        public async Task<IActionResult> DeleteHousePrice(int id)
        {
            if (_context.HousePrice == null)
            {
                return NotFound();
            }
            var housePrice = await _context.HousePrice.FindAsync(id);
            if (housePrice == null)
            {
                return NotFound();
            }

            _context.HousePrice.Remove(housePrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // Patch Method with api url   
        [HttpPatch("public/patchHousePrice/{id}")]
        public async Task<IActionResult> PatchHousePrice(int id, HousePriceDTOPublic hp)
        {


            var existingHousePrice = await _context.HousePrice.FindAsync(id);

            //add other a few other fields here
            existingHousePrice.RegionName = hp.RegionName;
            existingHousePrice.StateName = hp.StateName;
            existingHousePrice.Aug2023 = hp.Aug2023;
            existingHousePrice.Sep2023 = hp.Sep2023;
            existingHousePrice.Oct2023 = hp.Oct2023;

            await _context.SaveChangesAsync();
            return NoContent();





      }


       

        private bool HousePriceExists(int id)
        {
            return (_context.HousePrice?.Any(e => e.RegionID == id)).GetValueOrDefault();
        }
    }
}
