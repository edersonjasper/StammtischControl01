﻿using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace StammtischControl.Controllers.CadastroGeral
{
    public class CtrParticipanteController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("FrmParticipante");
        }
    }
}
