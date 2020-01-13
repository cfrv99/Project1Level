using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites.Configurations
{
    public class FreelancerPostConfiguration : IEntityTypeConfiguration<FreelancerPost>
    {

        public void Configure(EntityTypeBuilder<FreelancerPost> builder)
        {
            builder.HasKey(bs => new { bs.PostId, bs.FeelancerId });


            builder.HasOne(fp => fp.Freelancer)
                .WithMany(fp => fp.FreelancerPosts)
                .HasForeignKey(fp => fp.FeelancerId);

            builder.HasOne(fp => fp.Post)
                .WithMany(fp => fp.FreelancerPosts)
                .HasForeignKey(fp => fp.PostId);
        }
    }
}
