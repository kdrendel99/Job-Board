using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController: Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
        List<JobOpening> allJobOpening = JobOpening.GetAll();
        return View(allJobOpening);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description)
    {
      JobOpening myJob = new JobOpening(title, description);
      return RedirectToAction("Index");
    }
  }
}