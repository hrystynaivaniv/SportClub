using Microsoft.EntityFrameworkCore;

namespace SportClub
{
    public class SportClubDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<SeasonTicket> SeasonTickets { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Hall> Halls { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Client)
                .WithMany()
                .HasForeignKey(r => r.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Training>()
          .HasOne(t => t.Trainer)
          .WithMany()
          .HasForeignKey(t => t.TrainerID)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Training>()
                .HasOne(t => t.Hall)
                .WithMany()
                .HasForeignKey(t => t.HallID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Training>()
                .HasOne(t => t.Trainer)
                .WithMany()
                .HasForeignKey(t => t.TrainerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Training)
                .WithMany()
                .HasForeignKey(s => s.TrainingID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Trainer)
                .WithMany()
                .HasForeignKey(s => s.TrainerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Hall)
                .WithMany()
                .HasForeignKey(s => s.HallID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Client)
                .WithMany()
                .HasForeignKey(r => r.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Training)
                .WithMany()
                .HasForeignKey(r => r.TrainingID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                 .HasOne<SeasonTicket>()
       .WithMany()
       .HasForeignKey("SeasonTicketID")
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
    .HasOne(p => p.Client)
    .WithMany()
    .HasForeignKey(p => p.ClientID)
    .OnDelete(DeleteBehavior.Cascade);

        }


        public SportClubDbContext()
        {
            //Database.EnsureCreated();
        }

        public SportClubDbContext(DbContextOptions<SportClubDbContext> opts): base(opts)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);

            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SportClubDb;Integrated Security=True;";
            options.UseSqlServer(connStr);
        }

    }
}
