using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppServices.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<App> Apps { get; set; }
    }
}
