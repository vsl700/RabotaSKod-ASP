using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabotaSKod_ASP.Models.ViewModel
{
    public class ContactsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }
        public ICollection<ContactsViewModel> Items { get; set; }
    }
}
