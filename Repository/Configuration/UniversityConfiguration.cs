using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.Configuration;

public class UniversityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.HasData
        (
            new University
            {
                Id = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                Name = "Damanhour University",
                Description= "Damanhour University is a competitive institution in the domain of learning and pure scientific research which aims to build a learning society and to create knowledge.",
                Rate = 0
            },
            new University
            {
                Id = new Guid("e8c82519-d0c8-4c34-8cc7-a2e819644537"),
                Name = "Alexandria University",
                Description = "Alexandria University is a public university in Alexandria, Egypt. It was established in 1938 as a satellite of Fouad University, becoming an independent entity in 1942. It was known as Farouk University until after the Egyptian Revolution of 1952, when its name was changed to the University of Alexandria.",
                Rate = 0
            },
            new University
            {
                Id = new Guid("0102ff47-f01d-4614-8300-e9b9e1aad19b"),
                Name = "Kafr El Sheikh University",
                Description = "Kafr El Sheikh University is an Egyptian university established in 2006, located at Kafr El Sheikh, in the middle of the Nile Delta.",
                Rate = 0
            },
            new University
            {
                Id = new Guid("de1307a8-d751-402a-b649-4ffeabb70ac2"),
                Name = "Tanta University",
                Description = "Tanta University is an Egyptian university in the city of Tanta, Al Gharbiyah governorate, Egypt. The university is under the direct scientific supervision of the Ministry of Higher Education.",
                Rate = 0
            }
        );
    }
}
