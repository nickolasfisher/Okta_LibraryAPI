using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Checkout> Checkout { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Author = "J. R. R. Tolkien", Description= "The Fellowship of the Ring, the first volume in the trilogy, tells of the fateful power of the One Ring. It begins a magnificent tale of adventure that will plunge the members of the Fellowship of the Ring into a perilous quest and set the stage for the ultimate clash between the powers of good and evil.", Title = "The Fellowship of the Ring"});
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Author = "J. R. R. Tolkien", Description = "The Fellowship has been forced to split up. Frodo and Sam must continue alone towards Mount Doom, where the One Ring must be destroyed. Meanwhile, at Helm’s Deep and Isengard, the first great battles of the War of the Ring take shape.", Title = "The Two Towers" });

            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, Author = "J. R. R. Tolkien", Description = "The Return of the King is the towering climax to J. R. R. Tolkien’s trilogy that tells the saga of the hobbits of Middle-earth and the great War of the Rings. In this concluding volume, Frodo and Sam make a terrible journey to the heart of the Land of the Shadow in a final reckoning with the power of Sauron.", Title = "The Return of the King" });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, Author = "J. R. R. Tolkien", Description = "Like every other hobbit, Bilbo Baggins likes nothing better than a quiet evening in his snug hole in the ground, dining on a sumptuous dinner in front of a fire. But when a wandering wizard captivates him with tales of the unknown, Bilbo becomes restless. Soon he joins the wizard’s band of homeless dwarves in search of giant spiders, savage wolves, and other dangers. Bilbo quickly tires of the quest for adventure and longs for the security of his familiar home. But before he can return to his life of comfort, he must face the greatest threat of all - a treasure-troving dragon named Smaug.", Title = "The Hobbit" });

            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, Author = "Philip K Dick", Description = "It's America in 1962. Slavery is legal once again. The few Jews who still survive hide under assumed names. In San Francisco, the I Ching is as common as the Yellow Pages. All because some twenty years earlier the United States lost a war - and is now occupied by Nazi Germany and Japan.", Title = "The Man In The High Castle" });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 6, Author = "Jim Butcher", Description = "With rent past due and a decent meal becoming an issue of some importance, Harry needs work, and soon. A call from a distraught wife, and another from Lt. Murphy of the Chicago PD Special Investigation Unit makes Harry believe things are looking up, but they are about to get worse, much worse. Someone is harnessing immense supernatural forces to commit a series of grisly murders. Someone has violated the first law of magic: Thou Shalt Not Kill. Tracking that someone takes Harry into the dangerous underbelly of Chicago, from mobsters to vampires, while he himself is under suspicion of the crimes.", Title = "Storm Front" });

        }

    }
}
