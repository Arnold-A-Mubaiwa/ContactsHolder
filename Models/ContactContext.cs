using Microsoft.EntityFrameworkCore;

namespace ContactsHolder.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
        public DbSet<Contact> Contact { get; set; }
    }
}