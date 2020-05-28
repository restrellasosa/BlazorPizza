using BlazingPizza.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Models
{
    public class SeedData
    {
        public static void Initialize(PizzaStoreContext context)
        {
            var Toppings = new Topping[]
          {
                new Topping()
                {
                    Name = "Extra cheese",
                    Price = 2.50m,
                },
                new Topping()
                {
                    Name = "American bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "British bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "Canadian bacon",
                    Price = 2.99m,
                },
                new Topping()
                {
                    Name = "Tea and crumpets",
                    Price = 5.00m
                },
                new Topping()
                {
                    Name = "Fresh-baked scones",
                    Price = 4.50m,
                },
                new Topping()
                {
                    Name = "Bell peppers",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Onions",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Mushrooms",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Pepperoni",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Duck sausage",
                    Price = 3.20m,
                },
                new Topping()
                {
                    Name = "Venison meatballs",
                    Price = 2.50m,
                },
                new Topping()
                {
                    Name = "Served on a silver platter",
                    Price = 250.99m,
                },
                new Topping()
                {
                    Name = "Lobster on top",
                    Price = 64.50m,
                },
                new Topping()
                {
                    Name = "Sturgeon caviar",
                    Price = 101.75m,
                },
                new Topping()
                {
                    Name = "Artichoke hearts",
                    Price = 3.40m,
                },
                new Topping()
                {
                    Name = "Fresh tomatoes",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Basil",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Steak (medium-rare)",
                    Price = 8.50m,
                },
                new Topping()
                {
                    Name = "Blazing hot peppers",
                    Price = 4.20m,
                },
                new Topping()
                {
                    Name = "Buffalo chicken",
                    Price = 5.00m,
                },
                new Topping()
                {
                    Name = "Blue cheese",
                    Price = 2.50m,
                },
          };



            var Specials = new PizzaSpecial[]
            {
                new PizzaSpecial
                {
                    Name = "Pizza clásica de queso",
                    Description = "Es de queso y delicioso. ¿Por qué no querrías una?",
                    BasePrice = 189.99m,
                    ImageUrl = "css/images/pizzas/cheese.jpg"
                },
                new PizzaSpecial()
                {
                    Name = "Tocinator",
                    Description = "Tiene TODO tipo de tocino",
                    BasePrice = 227.99m,
                    ImageUrl = "css/images/pizzas/bacon.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Clásica de pepperoni",
                    Description = "Es la pizza con la que creciste, ¡pero ardientemente deliciosa!",
                    BasePrice = 199.50m,
                    ImageUrl = "css/images/pizzas/pepperoni.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Pollo búfalo",
                    Description = "Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor",
                    BasePrice = 228.75m,
                    ImageUrl = "css/images/pizzas/meaty.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Amantes del champiñón",

                    Description = "Tiene champiñones. ¿No es obvio?",
                    BasePrice = 209.00m,
                    ImageUrl = "css/images/pizzas/mushroom.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Hawaiana",
                    Description = "De piña, jamón y queso...",
                    BasePrice = 190.25m,
                    ImageUrl = "css/images/pizzas/hawaiian.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Delicia vegetariana",
                    Description = "Es como una ensalada, pero en una pizza",
                    BasePrice = 218.50m,
                    ImageUrl = "css/images/pizzas/salad.jpg",
                },
                new PizzaSpecial()
                {
                    Name = "Margarita",
                    Description = "Pizza italiana tradicional con tomates y albahaca",
                    BasePrice = 189.99m,
                    ImageUrl = "css/images/pizzas/margherita.jpg",
                }
            };

            context.Toppings.AddRange(Toppings);
            context.Specials.AddRange(Specials);
            context.SaveChanges();
        }
    }
    
}
