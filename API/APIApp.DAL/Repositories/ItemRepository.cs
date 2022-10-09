
using APIApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APIApp.DAL
{
    public class ItemRepository: IItemRepository
    {
        public async Task<EmissionItem> CreateItem(EmissionItem emissionItem)
        {
            try
            {
               
                return emissionItem;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<EmissionItem> GetItemById(EmissionItem emissionItem)
        {
            try
            {

                return emissionItem;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<EmissionItem> GetUnit(EmissionItem emissionItem)
        {
            try
            {

                return emissionItem;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
      

    }
}
