using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutomatedTellerMachine.Models;
using Microsoft.AspNet.Identity;

namespace AutomatedTellerMachine.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transactions
        public ActionResult Deposit()
        {
            return View();
        }

        
    }
       
}
