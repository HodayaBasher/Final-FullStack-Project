using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class Zmedicair_DBContext : DbContext
    {
        public Zmedicair_DBContext()
        {
        }

        public Zmedicair_DBContext(DbContextOptions<Zmedicair_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommonQuestionsTable> CommonQuestionsTables { get; set; }
        public virtual DbSet<DailyMonitoringTable> DailyMonitoringTables { get; set; }
        public virtual DbSet<MachinesTables> MachinesTables { get; set; }
        public virtual DbSet<MessagesTable> MessagesTables { get; set; }
        public virtual DbSet<ShoppingInformationTable> ShoppingInformationTables { get; set; }
        public virtual DbSet<ShoppingTable> ShoppingTables { get; set; }
        public virtual DbSet<UsersTable> UsersTables { get; set; }
        public object MessagesTable { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AP8782VQ;Database=Zmedicair_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<CommonQuestionsTable>(entity =>
            {
                entity.HasKey(e => e.CommonQuestionsId);

                entity.ToTable("CommonQuestions_Table");

                entity.Property(e => e.CommonQuestionsId).HasColumnName("CommonQuestionsID");

                entity.Property(e => e.CommonAnswers)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommonQuestions)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DailyMonitoringTable>(entity =>
            {
                entity.HasKey(e => e.DailyId)
                    .HasName("PK_DailyMonitoringֹֹֹֹֹֹ");

                entity.ToTable("DailyMonitoringֹֹֹֹ_Table");

                entity.Property(e => e.DailyId).HasColumnName("DailyID");

                entity.Property(e => e.DailyDateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DailyFeeling)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DailyMonitoringTables)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyMonitoringֹֹֹֹֹֹ_Users_Table");
            });

            modelBuilder.Entity<MachinesTables>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("Machines_Table");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MachinePrice).HasColumnType("money");
            });

            modelBuilder.Entity<MessagesTable>(entity =>
            {
                entity.HasKey(e => e.MessagesId)
                    .HasName("PK_Table_1");

                entity.ToTable("Messages_Table");

                entity.Property(e => e.MessagesId)
                    .ValueGeneratedNever()
                    .HasColumnName("MessagesID");

                entity.HasOne(d => d.UserIdFromWhoNavigation)
                    .WithMany(p => p.MessagesTableUserIdFromWhoNavigations)
                    .HasForeignKey(d => d.UserIdFromWho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_Table_Users_Table");

                entity.HasOne(d => d.UserIdToWhoNavigation)
                    .WithMany(p => p.MessagesTableUserIdToWhoNavigations)
                    .HasForeignKey(d => d.UserIdToWho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_Table_Users_Table1");
            });

            modelBuilder.Entity<ShoppingInformationTable>(entity =>
            {
                entity.HasKey(e => e.ShoppingInformationId);

                entity.ToTable("ShoppingInformation_Table");

                entity.Property(e => e.ShoppingInformationId).HasColumnName("ShoppingInformationID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ShoppingId).HasColumnName("ShoppingID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ShoppingInformationTables)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingInformation_Table_Machines_Table");

                entity.HasOne(d => d.Shopping)
                    .WithMany(p => p.ShoppingInformationTables)
                    .HasForeignKey(d => d.ShoppingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingInformation_Table_Shopping_Table");
            });

            modelBuilder.Entity<ShoppingTable>(entity =>
            {
                entity.HasKey(e => e.ShoppingId);

                entity.ToTable("Shopping_Table");

                entity.Property(e => e.ShoppingId).HasColumnName("ShoppingID");

                entity.Property(e => e.ShoppingDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShoppingTables)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shopping_Table_Users_Table1");
            });

            modelBuilder.Entity<UsersTable>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users_Table");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserDateOfBirth).HasColumnType("date");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
