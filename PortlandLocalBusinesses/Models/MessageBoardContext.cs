// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Proxies;
// using System;

// namespace PortlandLocalBusinesses.Models
// {
// 	public class PortlandLocalBusinessesContext : DbContext
// 	{
// 		public PortlandLocalBusinessesContext(DbContextOptions<PortlandLocalBusinessesContext> options) : base(options)
// 		{

// 		}

// 		public DbSet<Message> Messages {get; set;}
// 		public DbSet<Group> Groups {get; set;}

//     protected override void OnModelCreating(ModelBuilder builder)
//     {
//       builder.Entity<Group>()
//         .HasData(
//           new Group { GroupId = 1, Name= "Halloweenie Parties" },
//           new Group { GroupId = 2, Name= "Video Gaymezzzzz" },
//           new Group { GroupId = 3, Name= "Locate the PSL goodies" }
//         );

// 			builder.Entity<Message>()
// 				.HasData(
// 					new Message
// 					{ 
// 						MessageId = 1, 
// 						Title = "Scary Party???", 
// 						Body = "I'm looking for the spookiest party of all, please help???", 
// 						Author = "GhostiniLinguini",
// 						Date = new DateTime (2006, 6, 6),
// 						GroupId = 1
// 					},
// 					new Message
// 					{ 
// 						MessageId = 2, 
// 						Title = "No ghosts please", 
// 						Body = "I hate ghosts!!!  I want to go to a halloween party but if I see a ghost I'll p** my pants, please don't recommend parties w/ ghosts", 
// 						Author = "NoScariesPlease",
// 						Date = new DateTime (2010, 10, 29),
// 						GroupId = 1
// 					},
// 					new Message
// 					{ 
// 						MessageId = 3, 
// 						Title = "Gaming!!!!", 
// 						Body = "Holy CRUD I love gaming, particularly as a non-heterosexual/non-binary person.  It RULES!!!  I love Mountain Dew, also (unrelated).", 
// 						Author = "DewForMeAndU",
// 						Date = new DateTime (2003, 12, 18),
// 						GroupId = 2
// 					},
// 					new Message
// 					{ 
// 						MessageId = 4, 
// 						Title = "GAMING!!!!", 
// 						Body = "It's been ten years and I'm still gaming.  Darn, it still rules so hard.  Still not straight btw.", 
// 						Author = "DewForMeAndU",
// 						Date = new DateTime (2013, 12, 18),
// 						GroupId = 2
// 					},
// 					new Message
// 					{ 
// 						MessageId = 5, 
// 						Title = "Magical Drinks Needed!", 
// 						Body = "I'm looking for a magician that serves alchemical potions for all my spooky spells.", 
// 						Author = "WitchyTwitchy123",
// 						Date = new DateTime (1700, 10, 31),
// 						GroupId = 1
// 					},
// 					new Message
// 					{ 
// 						MessageId = 6, 
// 						Title = "Trader Joes PSL?", 
// 						Body = "I'm looking for the best Trader Joe's PSL treats. Please Help!!", 
// 						Author = "PSLlov3rkissessxoxo",
// 						Date = new DateTime (2020, 11, 2),
// 						GroupId = 3
// 					}
// 				);
//     }
//   }
// }