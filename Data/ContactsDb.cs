using Microsoft.EntityFrameworkCore;
using RabotaSKod_ASP.Models;

namespace RabotaSKod_ASP.Data
{
    public class ContactsDb : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactsDb(DbContextOptions<ContactsDb> options) : base(options)
        {

        }
    }
}
