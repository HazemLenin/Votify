using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votify.Domain.Common;

namespace Votify.Domain.Entities
{
    public class Poll : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string UserId { get; set; }

        public User User { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
