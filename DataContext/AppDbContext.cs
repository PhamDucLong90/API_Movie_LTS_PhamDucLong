using Microsoft.EntityFrameworkCore;
using Project_XemPhim.entity;

namespace Project_XemPhim.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<ConfirmEmail> ConfirmEmail { get; set; }
        public DbSet<RankCustomer> RankCustomer { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillFood> BillFood { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<GeneralSetting> GeneralSetting { get; set; }
        public DbSet<BillStatus> BillStatus { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<MovieType> MovieType { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<SeatStatus> SeatStatus { get; set; }
        public DbSet<SeatType> SeatType { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<BillTicket> BillTicket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8CCE635\\PHAMDUCLONG;Database=Project_XemPhim;User Id=sa;Password=123456;Trusted_Connection = True;TrustServerCertificate=True");

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Ticket>()
        //      .HasOne(b => b.Seat)
        //      .WithMany(u => u.tickets)
        //      .HasForeignKey(b => b.SeatId)
        //      .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Bill>()
        //        .HasOne(b => b.User)
        //        .WithMany(u => u.bills)
        //        .HasForeignKey(b => b.UserId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //}
    }
}
