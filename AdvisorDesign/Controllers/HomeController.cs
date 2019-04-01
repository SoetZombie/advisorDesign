using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvisorDesign.Models;

namespace AdvisorDesign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SchoolRegister()
        {

            return View();
        }

        public ActionResult IndividualRegister()
        {

            return View();
        }

        public ActionResult RegisterSingle()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult StudentRegister()
        {
            var studentRegisterModel = new StudentRegisterModel
            {
                SchoolName = new List<SelectListItem>(){
                    // First element has to be empty in order to display placeholder, otherwise it would automatically select the first option
                    new SelectListItem()
                    {
                       

                    },
                    new SelectListItem()
                    {
                        Selected = false, Text = "Ostrava", Value = "1"

                    },
                    new SelectListItem()
                    {
                        Selected = false, Text = "Opava", Value = "2"

                    }
                },
                ClassName = new List<SelectListItem>(){
                    // First element has to be empty in order to display placeholder, otherwise it would automatically select the first option
                    new SelectListItem()
                    {


                    },
                    new SelectListItem()
                    {
                        Selected = false, Text = "1A", Value = "1"

                    },
                    new SelectListItem()
                    {
                        Selected = false, Text = "2A", Value = "2"

                    }
                }
            };

            return View(studentRegisterModel);
        }
    }
}