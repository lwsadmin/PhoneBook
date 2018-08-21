using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Controllers;
using PhoneBook.PhoneBooks;
using PhoneBook.PhoneBooks.Dto;

namespace PhoneBook.Web.Controllers
{
    public class PersonController : PhoneBookControllerBase
    {
        private readonly IPersonAppService _catServices;
        public PersonController(IPersonAppService catServices)
        {
            _catServices = catServices;
        }
        public ActionResult Index()
        {
            var dtos = _catServices.GetAllListAsync();
            return View(dtos);
        }
    }
}