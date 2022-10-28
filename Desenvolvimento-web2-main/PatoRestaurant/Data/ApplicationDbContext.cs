using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PatoRestaurant.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public Dbset<ApplicationUser> ApplicationUsers { get; set; }

    public Dbset<Category> Categories { get; set ;}
    public Dbset<Product> Products { get; set ;}
    public Dbset<Reservation> Reservations { get; set ;}
    public Dbset<Review> Reviews { get; set ;}
    public Dbset<SocialEvent> SocialEvents { get; set ;}
    public Dbset<StatusReservation> StatusReservations { get; set ;}
    
}
