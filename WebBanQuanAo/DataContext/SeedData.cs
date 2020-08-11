using System;
using System.Linq;
using WebBanQuanAo.Models;

namespace WebBanQuanAo.DataContext
{
    public static class SeedData
    {
        public static void Initialize(BusinessContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categories.Any())
            {
                return;
            }
            var categories = new Category[]
            {
                    new Category{CategoryID="Q",Name="Quan"},
                    new Category{CategoryID="A",Name="Ao"},
            };
            foreach (Category ct in categories)
            {
                context.Categories.Add(ct);
            }
            context.SaveChanges();
            var products = new Product[]
            {
                    new Product{ID="Q-1",Name="Quần jean",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="Q"},
                    new Product{ID="Q-2",Name="Quần đùi",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="Q"},
                    new Product{ID="Q-3",Name="Quần dài",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="Q"},
                    new Product{ID="Q-4",Name="Quần lửng",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="Q"},
                    new Product{ID="A-1",Name="Áo thun",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="A"},
                    new Product{ID="A-2",Name="Áo khoát",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="A"},
                    new Product{ID="A-3",Name="Áo sơ mi",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="A"},
                    new Product{ID="A-4",Name="Áo ba lỗ",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="A"},
                    new Product{ID="A-5",Name="Áo đá banh",Avatar=null,Quantity=10,PurchasePrice=30,RetailPrice=31,DateEntry=DateTime.Parse("17-8-2020"),CategoryID="A"}
            };
            foreach (Product pr in products)
            {
                context.Products.Add(pr);
            }
            context.SaveChanges();
            var producers = new Producer[]
            {
                    new Producer{ProducerID="TQ",Name="Trung Quốc",Adress="Trung Quốc",Email=null,PhoneNumber=1234},
                    new Producer{ProducerID="VN",Name="Viet Nam",Adress="Viet Nam",Email=null,PhoneNumber=1234},
            };
            foreach (Producer pd in producers)
            {
                context.Producers.Add(pd);
            }
            context.SaveChanges();
            var custommer = new Customer[]
            {
                    new Customer{Name="Linh",Adress="Đà Nẵng",Email="thilylinh98@gmail.com",PhoneNumber=095973081}
            };
            foreach (Customer c in custommer)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
        }
    }
}