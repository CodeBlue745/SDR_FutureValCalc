using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

public class HomeController : Controller
{
    /// <summary>
    /// Field all get requests
    /// </summary>
    /// <returns>View [Object object]</returns>
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FV = 0;//Set the ViewBag object = 0.
        return View();//return the view object
    }
    /// <summary>
    /// Field all post requests
    /// </summary>
    /// <returns>View [Object object] with a model parameter that we calculated in our model.</returns>
    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        if (ModelState.IsValid)//If the HTTP Request is valid
        {
            ViewBag.FV = model.CalculateFutureValue();//Assign a function from the model to the public ViewBag from the view.
        }
        else
        {
            ViewBag.FV = 0;//Assign the public object to 0.
        }
        return View(model);//return the view with the FutureValueModel public paremeters.
    }
}

