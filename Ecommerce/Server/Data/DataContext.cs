namespace Ecommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
        new Product
        {
            Id = 1,
            Title = "Pokemon Red, Blue and Yellow bundle",
            Description = "Experience the very beginning as we go back to the first generation that started it all.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/af/Pok%C3%A9mon_Red_and_Blue_cover_art.webp/546px-Pok%C3%A9mon_Red_and_Blue_cover_art.webp.png",
            Price = 80.00m
        },
        new Product
        {
            Id = 2,
            Title = "Pokemon Gold and Silver bundle",
            Description = "Experience the sequels that changed everything and perfected the formula for the biggest franchice in the early 2000s.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4c/Pok%C3%A9mon_box_art_-_Gold_Version.png",
            Price = 299.99m
        },
        new Product
        {
            Id = 3,
            Title = "Pokemon Ruby and Sapphire bundle",
            Description = "The wild child of the ever growing family of triple pack games and the start of the advanced generation of poekmon games, with more features than you could possibly count!",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/be/PokemonRubySapphireBox.jpg",
            Price = 479.95m
        }

                );
        }


        public DbSet<Product> Products { get; set; }
    }
}
