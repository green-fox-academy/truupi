using ContactCardApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactCardApp.Entities
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<ContactCard> ContactCards { get; set; }
    }
}
