using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NARKSpawn
{
    public partial class NarkspawnContext : DbContext
    {
        public virtual DbSet<Commands> Commands { get; set; }
        public virtual DbSet<Dinos> Dinos { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
#if DEBUG //use init database
            optionsBuilder.UseSqlite(@"Data Source=""..\..\database\NarkSpawn.db""");
#else
    optionsBuilder.UseSqlite(@"Data Source=""database\NarkSpawn.db"""); 
#endif      
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commands>(entity =>
            {
                entity.HasKey(e => e.Dbid)
                    .HasName("PK_commands");

                entity.ToTable("commands");

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.Arg1).HasColumnName("arg1");

                entity.Property(e => e.Arg2).HasColumnName("arg2");

                entity.Property(e => e.Arg3).HasColumnName("arg3");

                entity.Property(e => e.Arg4).HasColumnName("arg4");

                entity.Property(e => e.Arg5).HasColumnName("arg5");

                entity.Property(e => e.Arg6).HasColumnName("arg6");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Cmd).HasColumnName("cmd");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Example).HasColumnName("example");

                entity.Property(e => e.IsCheat)
                    .HasColumnName("isCheat")
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Type2).HasColumnName("type2");
            });

            modelBuilder.Entity<Dinos>(entity =>
            {
                entity.HasKey(e => e.Dbid)
                    .HasName("PK_dinos");

                entity.ToTable("dinos");

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Longpath)
                    .IsRequired()
                    .HasColumnName("longpath");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Shortpath)
                    .IsRequired()
                    .HasColumnName("shortpath");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Type2).HasColumnName("type2");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.Dbid)
                    .HasName("PK_items");

                entity.ToTable("items");

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Type2).HasColumnName("type2");
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.Dbid)
                    .HasName("PK_types");

                entity.ToTable("types");

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });
        }
    }
}