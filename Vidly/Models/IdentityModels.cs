﻿//using System.Data.Entity;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using System.ComponentModel.DataAnnotations;

//namespace Vidly.Models
//{
    //// Puede agregar datos del perfil del usuario agregando más propiedades a la clase ApplicationUser. Para más información, visite http://go.microsoft.com/fwlink/?LinkID=317594.
    //public class ApplicationUser : IdentityUser
    //{
    //    [Required]
    //    [StringLength(255)]
    //    public string DrivingLicense { get; set; }

    //    [Required]
    //    [Display(Name = "Teléfono")]
    //    [StringLength(50)]
    //    public string Telefono { get; set; }
    //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    //    {
    //        // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
    //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
    //        // Agregar aquí notificaciones personalizadas de usuario
    //        return userIdentity;
    //    }
    //}

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public DbSet<Customer> Customers { get; set; }

    //    public DbSet<Movie> Movies { get; set; }

    //    public DbSet<MembershipType> MembershipTypes { get; set; }

    //    public DbSet<Genre> Genre { get; set; }
        
    //    //aqui iria movies
    //    //public TYPE Type { get; set; }
    //    public ApplicationDbContext()
    //        : base("DefaultConnection", throwIfV1Schema: false)
    //    {
    //    }

    //    public static ApplicationDbContext Create()
    //    {
    //        return new ApplicationDbContext();
    //    }
    //}
//}