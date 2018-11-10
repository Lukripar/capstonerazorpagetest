using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Data;
using RazorPagesSample.Entities;

namespace RazorPagesSample.Web.Pages.Stores
{
    public class IndexModel : PageModel
    {
        private readonly IStoreRepository _storeRepo;
        public ICollection<Store> Stores { get; set; }

        // The IStoreRepository is injected by the runtime, which is defined in our Startup.cs file.
        public IndexModel(IStoreRepository storeRepo)
        {
            _storeRepo = storeRepo;
            Stores = new List<Store>();
        }

        // This function gets called everytime the user retreives this web page. 
        // Do any longer running tasks here, such as database access. 
        public void OnGet()
        {
            Stores = _storeRepo.GetAll();
        }
    }
}