using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votify.Domain.Common;

namespace Votify.Domain.Entities
{
    public class Vote : BaseEntity
    {
        public string UserId { get; set; }
        public string CandidateId { get; set; } 

        public User User { get; set; }
        public Candidate Candidate { get; set; }
    }
}
