using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using System;

namespace PdxLocalBusinesses.Models
{
	public class PdxLocalBusinessesContext : DbContext
	{
		public PdxLocalBusinessesContext(DbContextOptions<PdxLocalBusinessesContext> options) : base(options)
		{

		}

		public DbSet<Business> Businesses {get; set;}
		public DbSet<Neighborhood> Neighborhoods {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Neighborhood>()
        .HasData(
          new Neighborhood { NeighborhoodId = 1, Name= "Northwest Portland" },
          new Neighborhood { NeighborhoodId = 2, Name= "Pearl District" },
          new Neighborhood { NeighborhoodId = 3, Name= "Goose Hollow Foothills League" },
          new Neighborhood { NeighborhoodId = 4, Name= "Portland Downtown" },
          new Neighborhood { NeighborhoodId = 5, Name= "Laurelhurst" },
          new Neighborhood { NeighborhoodId = 6, Name= "Arlington Heights" },
          new Neighborhood { NeighborhoodId = 7, Name= "Sellwood - Moreland" },
          new Neighborhood { NeighborhoodId = 8, Name= "Eastmoreland" },
          new Neighborhood { NeighborhoodId = 9, Name= "Irvington" },
          new Neighborhood { NeighborhoodId = 10, Name= "Southwest Hills" },
          new Neighborhood { NeighborhoodId = 11, Name= "Hosford-Abernethy" },
          new Neighborhood { NeighborhoodId = 12, Name= "Northwest Heights" },
          new Neighborhood { NeighborhoodId = 13, Name= "Beaumont - Wilshire" },
          new Neighborhood { NeighborhoodId = 14, Name= "Healy Heights" },
          new Neighborhood { NeighborhoodId = 15, Name= "Kerns" },
          new Neighborhood { NeighborhoodId = 16, Name= "South Portland" },
          new Neighborhood { NeighborhoodId = 17, Name= "Forest Park" },
          new Neighborhood { NeighborhoodId = 18, Name= "Sylvan - Highlands" },
          new Neighborhood { NeighborhoodId = 19, Name= "Old Town" },
          new Neighborhood { NeighborhoodId = 20, Name= "Sullivan's Gulch" },
          new Neighborhood { NeighborhoodId = 21, Name= "Marshall Park" },
          new Neighborhood { NeighborhoodId = 22, Name= "Northwest Industrial" },
          new Neighborhood { NeighborhoodId = 23, Name= "Grant Park" },
          new Neighborhood { NeighborhoodId = 24, Name= "Northeast Portland" },
          new Neighborhood { NeighborhoodId = 25, Name= "Hollywood" },
          new Neighborhood { NeighborhoodId = 26, Name= "Buckman" },
          new Neighborhood { NeighborhoodId = 27, Name= "Arnold Creek" },
          new Neighborhood { NeighborhoodId = 28, Name= "Collins View" },
          new Neighborhood { NeighborhoodId = 29, Name= "South Waterfront" },
          new Neighborhood { NeighborhoodId = 30, Name= "Mount Tabor" },
          new Neighborhood { NeighborhoodId = 31, Name= "Multnomah" },
          new Neighborhood { NeighborhoodId = 32, Name= "Overlook" },
          new Neighborhood { NeighborhoodId = 33, Name= "Hawthorne" },
          new Neighborhood { NeighborhoodId = 34, Name= "St.Johns" },
          new Neighborhood { NeighborhoodId = 35, Name= "Boise" },
          new Neighborhood { NeighborhoodId = 36, Name= "Central Eastside" },
          new Neighborhood { NeighborhoodId = 37, Name= "Nob Hill" },
          new Neighborhood { NeighborhoodId = 38, Name= "Montavilla" },
          new Neighborhood { NeighborhoodId = 39, Name= "Southeast Portland" },
          new Neighborhood { NeighborhoodId = 40, Name= "Pleasant Valley" },
          new Neighborhood { NeighborhoodId = 41, Name= "Lloyd District" },
          new Neighborhood { NeighborhoodId = 42, Name= "Creston - Kenilworth" },
          new Neighborhood { NeighborhoodId = 43, Name= "University Park" },
          new Neighborhood { NeighborhoodId = 44, Name= "Cully" },
          new Neighborhood { NeighborhoodId = 45, Name= "Southwest Portland" },
          new Neighborhood { NeighborhoodId = 46, Name= "Sabin" },
          new Neighborhood { NeighborhoodId = 47, Name= "Alameda" },
          new Neighborhood { NeighborhoodId = 48, Name= "Richmond" },
          new Neighborhood { NeighborhoodId = 49, Name= "Sunnyside" },
          new Neighborhood { NeighborhoodId = 50, Name= "Hillsdale" }
        );

			builder.Entity<Business>()
				.HasData(
					new Business
					{ 
						BusinessId = 1, 
						Name = "Abigayle Tarsches Photography",
            Description = "Portrait, Branding, and Boudoir Photography",  
						PhoneNumber = "415-609-7914", 
						NeighborhoodId = 1
					},
          new Business
					{ 
						BusinessId = 2, 
						Name = "Gladys Bikes",
            Description = "Full service bike shop",  
						PhoneNumber = "971-373-8388", 
						NeighborhoodId = 1
					},
          new Business
					{ 
						BusinessId = 3, 
						Name = "Moods of Florence Italy",
            Description = "Women's clothing, costume jewelry, accessories, fashion face mask",  
						PhoneNumber = "503-740-1874", 
						NeighborhoodId = 19
					},
          new Business
					{ 
						BusinessId = 4, 
						Name = "Shoe",
            Description = "Local family owned shoe repair in the Hollywood District",  
						PhoneNumber = "503-206-6455", 
						NeighborhoodId = 25
					},
					new Business
					{ 
						BusinessId = 5, 
						Name = "Photo to Canvas",
            Description = "Your photos printed on Canvas and Fine Art Papers",  
						PhoneNumber = "503-896-5643", 
						NeighborhoodId = 41
					}

				);
    }
  }
}