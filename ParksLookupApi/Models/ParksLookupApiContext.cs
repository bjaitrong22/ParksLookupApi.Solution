using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext: DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Category = "National Park", Name = "Rocky Mountain National Park", Address = "1000 Highway 36, Estes Park, CO 80517", Activities= " Camping, Hiking, Snowshoeing, Fishing, WildLife Observation. Visitor Information Line: 970-586-1206"},
          new Park { ParkId = 2, Category = "National Park", Name = "Mesa Verde National Park", Address = " Mesa Verde, CO", Activities = " Camping, Hiking, Cliff Dwelling Tours, Bird Watching, Geologic Views. Visitor information Line: 970-529-4465"},
          new Park { ParkId = 3, Category = "State Park", Name = "Barr Lake", Address = "13401 Picadilly Rd, Brighton, CO 80603", Activities = "Camping, Birding, Trails, Fishing, Boating, Biking. Park Office number: 720-520-1876"},
          new Park { ParkId = 4, Category = "State Park", Name = "Steamboat Lake", Address= " 61105 RCR 129, Clark, CO 80429", Activities = " Camping, Birding, Trails, Fishing, Boating, Biking, Snowshoeing, Cross-Country Skiing, Kayaking. Park Offic number: 970-879-3922"}
        );
    }
  }
}