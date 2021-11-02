using Microsoft.EntityFrameworkCore;
using RabotaSKod_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
