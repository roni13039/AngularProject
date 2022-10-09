using APIApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IItemRepository _iItemRepository;
        public ItemController(IItemRepository iItemRepository)
        {
            _iItemRepository = iItemRepository;
        }

        [Route("GetConversionUnit")]
        [HttpGet]
        public string GetConversionUnit()
        {
            var result= _iItemRepository.GetUnit();

            return JsonConvert.SerializeObject(result);
        }

     
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

     
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
