using System;
using System.Collections.Generic;

namespace CarDealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> { };
    private static List<Car> _worthBuyingInstances = new List<Car> { };
    public static int MaxPrice { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> WorthBuying(int maxPrice)
    {
      _worthBuyingInstances.Clear();
      foreach (Car automobile in _instances)
      {
        if (automobile.Price <= maxPrice)
        {
          _worthBuyingInstances.Add(automobile);
        }
      }
      return _worthBuyingInstances;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static List<Car> GetAllMatching()
    {
      return _worthBuyingInstances;
    }
  }
}
