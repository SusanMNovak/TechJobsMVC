using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            ViewBag.title = "Search";
            return View();
        }

        //TODO #1 Create a Results action method to pocess search request and display results.

        public IActionResult Results(strimg searchType, string searchTerm)
        {
            ViewBag.columns = ListController.ColumnChoices;
            if (searchType != "all")
            {
                List<Dictionary<string, string>> jobs = JobData.findByColumnAndValue(searchType, searchTerm);
                ViewBag.jobs = jobs;
                ViewBag.title = "Resulte for '" + searchTerm + "' in " + searchType;
                return View("Index", jobs);
            }
            else
            {
                List<Dictionary<string, string>> jobs = JobData.findByValue(searchTerm);
                ViewBag.jobs = jobs;
                ViewBag.title = "Resulte for '" + searchTerm + "' in Alll jobs;
                return View("Index", jobs);
            }
        }

        // TODO #3: Create an action method to process a search request and render the updated search view. 
       // public String search(ModelBinderAttribute, ModelBinderAttribute, RequestFormLimitsAttribute String searchTerm)
       // {
       //     ArrayList<HashMap<String, string>> jobs;
         //   if (searchType.equals("all"))
           // {
             //   jobs = JobData.findByValue(searchTerm);
          //  }
           // else
            {//
            //    jobs = JobData.findByColumnValue(searchType, searchTerm);
           // }
          //  Model.addAttribute("columns", ListController.ColumnChoices);
         //   Model.addAttribute.addAtribute("jobs", jobs);
         //   Model.addAtribute("searchType", searchType);
         //
           // return "search";
                       
    }
}
