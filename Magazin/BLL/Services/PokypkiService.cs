using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PokypkiService : IPokypkiService
    {
        private IDbRepos db;
        public PokypkiService(IDbRepos repos)
        {
            db = repos;
        }



        public bool MakePokypka(PokProdModel pokprodDto)
        {
            //    List<PokProd> pokypkiproduktov = new List<PokProd>();
            //    decimal sum = 0;
            //    foreach (var pId in pokprodDto.OrderedPhonesIds)
            //    {
            //        Phone phone = db.Phones.GetItem(pId);
            //        // валидация
            //        if (phone == null)
            //            throw new Exception("Телефон не найден");
            //        sum += phone.Cost;
            //        orderedphones.Add(phone);
            //    }
            //    // применяем скидку
            //    sum = new Discount(0.1m).GetDiscountedPrice(sum);
            //    Order order;
            //    if (orderDto.Id > 0)
            //    {
            //        order = db.Orders.GetItem(orderDto.Id);
            //        order.Date = DateTime.Now;
            //        order.Address = orderDto.Address;
            //        order.Total = sum;
            //        order.PhoneNumber = orderDto.PhoneNumber;
            //        order.Customer = orderDto.Customer;
            //        order.Phones = orderedphones;
            //        db.Orders.Update(order);
            //    }
            //    else
            //    {
            //        order = new Order
            //        {
            //            Date = DateTime.Now,
            //            Address = orderDto.Address,
            //            Total = sum,
            //            PhoneNumber = orderDto.PhoneNumber,
            //            Customer = orderDto.Customer,
            //            Phones = orderedphones
            //        };
            //        db.Orders.Create(order);
            //    }
            if (db.Save() > 0)
                return true;
            return false;

        }
    }
}