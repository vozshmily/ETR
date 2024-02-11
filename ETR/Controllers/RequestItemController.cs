using ETR.Data;
using ETR.Models;
using ETR.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETR.Controllers
{
    public class RequestItemController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public RequestItemController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new AddRequestItemViewModel
            {
                RequestorName = null,
                RequestDate = DateTime.Now, // or set it to any default date
                ItemLists = new List<ItemListViewModel>
        {
            // Add an initial empty item
            new ItemListViewModel()
        }
            };

            return View(viewModel);
        }

        [HttpPost] 
        public async Task<IActionResult> Add(AddRequestItemViewModel viewModel) 
        {
            var requestItem = new RequestList
            {
                RequestorName = viewModel.RequestorName,
                RequestDate = viewModel.RequestDate
            };
            await dbContext.RequestLists.AddAsync(requestItem);
            await dbContext.SaveChangesAsync();


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var requestItems = await dbContext.RequestLists.ToListAsync();
            return View(requestItems);
        }
    }
}
