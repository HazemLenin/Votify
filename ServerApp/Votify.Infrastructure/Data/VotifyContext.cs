using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votify.Domain.Entities;

namespace Votify.Infrastructure.Data
{
    public class VotifyContext : IdentityDbContext<User>
    {
        public VotifyContext(DbContextOptions<VotifyContext> options)
            : base(options)
        {
        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Poll>()
                .HasOne(x => x.User)
                .WithMany(x => x.Polls)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
