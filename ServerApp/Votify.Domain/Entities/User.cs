using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votify.Domain.Entities
{
    public class User : IdentityUser
    {
        public List<Poll> Polls { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
