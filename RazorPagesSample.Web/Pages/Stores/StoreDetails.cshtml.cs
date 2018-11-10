using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Data;
using RazorPagesSample.Entities;
using RazorPagesSample.Services;

namespace RazorPagesSample.Web.Pages.Stores
{
    public class StoreDetailsModel : PageModel
    {
        private readonly IStoreRepository _storeRepo;
        private readonly IEmailSender _emailSender;

        public Store Store { get; set; }

        public StoreDetailsModel(IStoreRepository storeRepo, IEmailSender emailSender)
        {
            _storeRepo = storeRepo;
            _emailSender = emailSender;
        }

        public void OnGet(int id)
        {
            Store = _storeRepo.Get(id);
            _emailSender.SendEmails("codyclay88@gmail.com", "Yo!", "Hey frand");
        }
    }
}