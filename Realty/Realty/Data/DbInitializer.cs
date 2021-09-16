using RealtyProg.Models;
using System.Linq;

namespace RealtyProg.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RealtyContext context)
        {
            context.Database.EnsureCreated();

            if (context.Property.Any())
            {
                return;
            }

            var prop = new Property[]
            {
                new Property{Name="Комната"},
                new Property{Name="Квартира"},
                new Property{Name="Дом"}

            };
            foreach (Property pr in prop)
            {
                context.Property.Add(pr);
            }
            context.SaveChanges();


        }
    }
}
