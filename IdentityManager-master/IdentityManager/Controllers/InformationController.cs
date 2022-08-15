using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using IdentityManager.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IdentityManager.Models;


namespace IdentityManager.Controllers
{
    public class InformationController : Controller
    {
        //GET: Catalogue
        public IActionResult Index()
        {
            return View();
        }
    }
}