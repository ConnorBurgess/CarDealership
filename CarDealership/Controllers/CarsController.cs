using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {
    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car newCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/car")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
  }
}