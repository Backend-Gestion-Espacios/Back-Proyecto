using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public byte Avatar { get; set; }

        public string Company { get; set; }
    }
}
