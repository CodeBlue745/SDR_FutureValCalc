using Microsoft.AspNetCore.Mvc;//Import Architecture library
using FutureValue.Models;//Import model

namespace FutureValue.Controllers//start namespace and create controller
{
    public class HomeController : Controller //inherit the controller class for HomeController
    {
        [HttpGet]//Field all Get requests.
        //The IAction is saying "I am an action" and executes when a Get request is sent to this method on the server.
        public IActionResult Index()
        {
            ViewBag.FV = 0;//Set the ViewBag object = 0.
            ViewBag.SDR = ""; //Initilize second object.
            return View();//Return both objects.
        }
        //Field all HTTP Post requests
        [HttpPost]
        public IActionResult Index(FutureValueModel model, FutureValueModel model2)//We pass two thread parameters through this method.
        {
            if (ModelState.IsValid)//If the HTTP Request is valid
            {
                ViewBag.FV = model.CalculateFutureValue();//Assign a function from the model to the public ViewBag from the view.
                ViewBag.SDR = model2.ReturnMathFormula();//Assign a function from the model to the public ViewBag from the view.
            }
            else
            {
                ViewBag.FV = 0;//Assign the public object to 0.
            }
            return View(model);//return the view with the model parameter.
        }
    }
}