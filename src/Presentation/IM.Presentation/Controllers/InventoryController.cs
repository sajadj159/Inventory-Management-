using IM.Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace IM.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryApplication _inventoryApplication;

        public InventoryController(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }


        [HttpPost]
        public bool Define(DefineInventory command)
        {
           return _inventoryApplication.Define(command);
        }
    }
}
