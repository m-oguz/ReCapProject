using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1, DailyPrice=100, Description="MB A180", ColorId=332, ModelYear=2016},
                new Car{Id=2, BrandId=2, DailyPrice=160, Description="BMW 740",ColorId=424, ModelYear=2019},
                new Car{Id=3, BrandId=2, DailyPrice=300, Description="BMW  i8",ColorId=321, ModelYear=2021},
                new Car{Id=4, BrandId=3, DailyPrice=190, Description="Model S",ColorId=532, ModelYear=2020},
                new Car{Id=5, BrandId=3, DailyPrice=160, Description="Model 3", ColorId=123,ModelYear=2020},
                new Car{Id=6, BrandId=4, DailyPrice=120, Description="AUDI A3",ColorId=875, ModelYear=2018},
                new Car{Id=7, BrandId=4, DailyPrice=150, Description="AUDI Q7",ColorId=564, ModelYear=2019},
                new Car{Id=8, BrandId=4, DailyPrice=130, Description="AUDI A6",ColorId=324, ModelYear=2016},
                new Car{Id=9, BrandId=5, DailyPrice=800, Description="Veyron ",ColorId=313, ModelYear=2020}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return  _cars.Where(car => car.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            _cars.SingleOrDefault(c => c.Id == car.Id).Id = car.Id;
            _cars.SingleOrDefault(c => c.Id == car.Id).Description = car.Description;
            _cars.SingleOrDefault(c => c.Id == car.Id).DailyPrice = car.DailyPrice;
            _cars.SingleOrDefault(c => c.Id == car.Id).ModelYear = car.ModelYear;
            _cars.SingleOrDefault(c => c.Id == car.Id).BrandId  = car.BrandId;


        }
    }
}
