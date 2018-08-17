using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeckonedPath.Library.Models
{
    public partial class PlayDBContext : DbContext
    {
        public virtual DbSet<CommunityComments> CommunityComments { get; set; }
        public virtual DbSet<Communitys> Communitys { get; set; }
        public virtual DbSet<EventComments> EventComments { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Users> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=tcp:project-2.database.windows.net,1433;Initial Catalog = PlayDB; Persist Security Info=False;User ID = sqladmin; Password=Revature1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<CommunityComments>(entity =>
//            {
//                entity.HasKey(e => e.CommunityCommentId);

//                entity.ToTable("CommunityComments", "PlayBPath");

//                entity.HasIndex(e => e.CommunityId);

//                entity.HasIndex(e => e.UserId);

//                entity.HasOne(d => d.Community)
//                    .WithMany(p => p.CommunityComments)
//                    .HasForeignKey(d => d.CommunityId);

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.CommunityComments)
//                    .HasForeignKey(d => d.UserId);
//            });

//            modelBuilder.Entity<Communitys>(entity =>
//            {
//                entity.HasKey(e => e.CommunityId);

//                entity.ToTable("Communitys", "PlayBPath");

//                entity.HasIndex(e => e.UserId);

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Communitys)
//                    .HasForeignKey(d => d.UserId);
//            });

//            modelBuilder.Entity<EventComments>(entity =>
//            {
//                entity.HasKey(e => e.EventCommentId);

//                entity.ToTable("EventComments", "PlayBPath");

//                entity.HasIndex(e => e.EventId);

//                entity.HasIndex(e => e.UserId);

//                entity.HasOne(d => d.Event)
//                    .WithMany(p => p.EventComments)
//                    .HasForeignKey(d => d.EventId)
//                    .OnDelete(DeleteBehavior.Cascade);

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.EventComments)
//                    .HasForeignKey(d => d.UserId);
//            });

//            modelBuilder.Entity<Events>(entity =>
//            {
//                entity.HasKey(e => e.EventId);

//                entity.ToTable("Events", "PlayBPath");

//                entity.HasIndex(e => e.CommunityId);

//                entity.HasIndex(e => e.UserId);

//                entity.Property(e => e.CommunityId).HasDefaultValueSql("((0))");

//                entity.Property(e => e.EventDate).HasColumnType("datetime2(2)");

//                entity.HasOne(d => d.Community)
//                    .WithMany(p => p.Events)
//                    .HasForeignKey(d => d.CommunityId)
//                    .OnDelete(DeleteBehavior.ClientSetNull);

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Events)
//                    .HasForeignKey(d => d.UserId)
//                    .OnDelete(DeleteBehavior.Cascade);
//            });

//            modelBuilder.Entity<Friends>(entity =>
//            {
//                entity.HasKey(e => e.FriendId);

//                entity.ToTable("Friends", "PlayBPath");

//                entity.HasIndex(e => e.UserId);

//                entity.Property(e => e.AnotherFriend).HasDefaultValueSql("((0))");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Friends)
//                    .HasForeignKey(d => d.UserId);
//            });

//            modelBuilder.Entity<Users>(entity =>
//            {
//                entity.HasKey(e => e.UserId);

//                entity.ToTable("Users", "PlayBPath");

//                entity.Property(e => e.Birthday).HasColumnType("datetime2(2)");

//                entity.Property(e => e.Comment).HasMaxLength(500);

//                entity.Property(e => e.Email)
//                    .IsRequired()
//                    .HasMaxLength(500);

//                entity.Property(e => e.Event).HasMaxLength(500);

//                entity.Property(e => e.FirstName)
//                    .IsRequired()
//                    .HasMaxLength(500);

//                entity.Property(e => e.FutureEvent).HasMaxLength(500);

//                entity.Property(e => e.LastName)
//                    .IsRequired()
//                    .HasMaxLength(500);

//                entity.Property(e => e.PastEvent).HasMaxLength(500);
//            });
//        }
    }
}
