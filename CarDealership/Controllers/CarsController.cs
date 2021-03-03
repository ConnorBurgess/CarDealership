using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
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

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/maxprice")]
    public ActionResult MaxPrice()
    {
      return View();
    }

    [HttpGet("/cars/inpricerange")]
    public ActionResult InPriceRange(int maxPrice)
    {
      List<Car> allCars = Car.WorthBuying(maxPrice);
      return View(allCars);
    }

  }
}