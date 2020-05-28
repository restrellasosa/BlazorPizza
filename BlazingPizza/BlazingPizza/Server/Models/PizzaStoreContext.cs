using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Models
{
    public class PizzaStoreContext : DbContext
    {
        public DbSet<PizzaSpecial> Specials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=RYAN;Database=PizzaStorage;persist security info=True;user=sa;password=ryan1973;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir la llave primaria de la entidad PizzaTopping
            modelBuilder.Entity<PizzaTopping>()
                .HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            // Una Pizza puede tener muchos Toppings.
            modelBuilder.Entity<PizzaTopping>()
                .HasOne<Pizza>().WithMany(ps => ps.Toppings);
            // Un Topping puede estar en muchas Pizzas. 
            modelBuilder.Entity<PizzaTopping>()
  .HasOne(pst => pst.Topping).WithMany();

            modelBuilder.Entity<Order>()
    .OwnsOne(o => o.DeliveryLocation);
        }

    }
}
