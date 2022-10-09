using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APIApp.Domain
{
   public interface IItemRepository
   {
        Task<EmissionItem> CreateItem(EmissionItem emissionItem);
        Task<EmissionItem> GetItemById(EmissionItem emissionItem);
        Task<EmissionItem> GetUnit(EmissionItem emissionItem);
    }
}
