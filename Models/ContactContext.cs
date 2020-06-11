using Microsoft.EntityFrameworkCore;

namespace ContactsHolder.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
        public DbSet<ContactsHolder.Models.Contact> Contact { get; set; }
    }
}