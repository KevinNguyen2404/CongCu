using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebChordCore.Models
{
    public partial class HopAmChuanContext : DbContext
    {
        public HopAmChuanContext()
        {
        }

        public HopAmChuanContext(DbContextOptions<HopAmChuanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Chord> Chords { get; set; } = null!;
        public virtual DbSet<ChordChordGroup> ChordChordGroups { get; set; } = null!;
        public virtual DbSet<ChordChordType> ChordChordTypes { get; set; } = null!;
        public virtual DbSet<ChordGroup> ChordGroups { get; set; } = null!;
        public virtual DbSet<ChordType> ChordTypes { get; set; } = null!;
        public virtual DbSet<GroupOfSinger> GroupOfSingers { get; set; } = null!;
        public virtual DbSet<GuestsWatch> GuestsWatches { get; set; } = null!;
        public virtual DbSet<ListOfImage> ListOfImages { get; set; } = null!;
        public virtual DbSet<Singer> Singers { get; set; } = null!;
        public virtual DbSet<SingerTone> SingerTones { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;
        public virtual DbSet<SongCategory> SongCategories { get; set; } = null!;
        public virtual DbSet<SongOfCountryCompose> SongOfCountryComposes { get; set; } = null!;
        public virtual DbSet<SongSinger> SongSingers { get; set; } = null!;
        public virtual DbSet<Tone> Tones { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KD4IHUI\\SQLEXPRESS;Initial Catalog=HopAmChuan;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });

            modelBuilder.Entity<Chord>(entity =>
            {
                entity.ToTable("Chord");

                entity.Property(e => e.KeyNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdListOfImageNavigation)
                    .WithMany(p => p.Chords)
                    .HasForeignKey(d => d.IdListOfImage)
                    .HasConstraintName("FK_Chord_ListOfImage");
            });

            modelBuilder.Entity<ChordChordGroup>(entity =>
            {
                entity.ToTable("Chord_ChordGroup");

                entity.HasOne(d => d.IdChorGroupNavigation)
                    .WithMany(p => p.ChordChordGroups)
                    .HasForeignKey(d => d.IdChorGroup)
                    .HasConstraintName("FK_Chordgroup_Chord_ChordGroup");

                entity.HasOne(d => d.IdChordNavigation)
                    .WithMany(p => p.ChordChordGroups)
                    .HasForeignKey(d => d.IdChord)
                    .HasConstraintName("FK_Chord_Chord_ChordGroup");
            });

            modelBuilder.Entity<ChordChordType>(entity =>
            {
                entity.ToTable("Chord_ChordType");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdChorTypeNavigation)
                    .WithMany(p => p.ChordChordTypes)
                    .HasForeignKey(d => d.IdChorType)
                    .HasConstraintName("FK_Chordgroup_Chord_ChordType");

                entity.HasOne(d => d.IdChordNavigation)
                    .WithMany(p => p.ChordChordTypes)
                    .HasForeignKey(d => d.IdChord)
                    .HasConstraintName("FK_Chord_Chord_ChordType");
            });

            modelBuilder.Entity<ChordGroup>(entity =>
            {
                entity.ToTable("ChordGroup");
            });

            modelBuilder.Entity<ChordType>(entity =>
            {
                entity.ToTable("ChordType");
            });

            modelBuilder.Entity<GroupOfSinger>(entity =>
            {
                entity.ToTable("GroupOfSinger");
            });

            modelBuilder.Entity<GuestsWatch>(entity =>
            {
                entity.ToTable("GuestsWatch");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ListOfImage>(entity =>
            {
                entity.ToTable("ListOfImage");
            });

            modelBuilder.Entity<Singer>(entity =>
            {
                entity.ToTable("Singer");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SingerTone>(entity =>
            {
                entity.ToTable("Singer_Tone");

                entity.HasOne(d => d.IdSingerNavigation)
                    .WithMany(p => p.SingerTones)
                    .HasForeignKey(d => d.IdSinger)
                    .HasConstraintName("FK_Singer_Tone_Singer");

                entity.HasOne(d => d.IdToneNavigation)
                    .WithMany(p => p.SingerTones)
                    .HasForeignKey(d => d.IdTone)
                    .HasConstraintName("FK_Singer_Tone_Tone");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("Song");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Link).HasColumnType("ntext");

                entity.Property(e => e.Tag).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.HasOne(d => d.IdAuthorNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.IdAuthor)
                    .HasConstraintName("FK_Song_Author");

                entity.HasOne(d => d.IdChordNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.IdChord)
                    .HasConstraintName("FK_Song_Chord");

                entity.HasOne(d => d.IdCountryComposesNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.IdCountryComposes)
                    .HasConstraintName("FK_Song_CountryComposes");

                entity.HasOne(d => d.IdGroupOfSingersNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.IdGroupOfSingers)
                    .HasConstraintName("FK_Song_GroupOfSingers");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_Song_User");
            });

            modelBuilder.Entity<SongCategory>(entity =>
            {
                entity.ToTable("Song_Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.SongCategories)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Song_Category_Category");

                entity.HasOne(d => d.IdSongNavigation)
                    .WithMany(p => p.SongCategories)
                    .HasForeignKey(d => d.IdSong)
                    .HasConstraintName("FK_Song_Category_Song");
            });

            modelBuilder.Entity<SongSinger>(entity =>
            {
                entity.ToTable("Song_Singer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdSingerNavigation)
                    .WithMany(p => p.SongSingers)
                    .HasForeignKey(d => d.IdSinger)
                    .HasConstraintName("FK_Song_Singer_Singer");

                entity.HasOne(d => d.IdSongNavigation)
                    .WithMany(p => p.SongSingers)
                    .HasForeignKey(d => d.IdSong)
                    .HasConstraintName("FK_Song_Singer");
            });

            modelBuilder.Entity<Tone>(entity =>
            {
                entity.ToTable("Tone");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.IdUserGroupNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdUserGroup)
                    .HasConstraintName("FK_User_UserGroup");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
