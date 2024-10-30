﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebChordCore.Models;

#nullable disable

namespace WebChordCore.Migrations
{
    [DbContext(typeof(HopAmChuanContext))]
    partial class HopAmChuanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebChordCore.Models.Author", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComposerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Chord", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdListOfImage")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("KeyNo")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdListOfImage");

                    b.ToTable("Chord", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.ChordChordGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdChorGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdChord")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdChorGroup");

                    b.HasIndex("IdChord");

                    b.ToTable("Chord_ChordGroup", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.ChordChordType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdChorType")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdChord")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdChorType");

                    b.HasIndex("IdChord");

                    b.ToTable("Chord_ChordType", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.ChordGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChordGroup", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.ChordType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChordType", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.GroupOfSinger", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfMembers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GroupOfSinger", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.GuestsWatch", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("char(20)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("GuestsWatch", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.ListOfImage", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListOfImage", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Singer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Singer", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.SingerTone", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdSinger")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdTone")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdSinger");

                    b.HasIndex("IdTone");

                    b.ToTable("Singer_Tone", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Song", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<bool?>("Activity")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<string>("IdAuthor")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdChord")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdCountryComposes")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdGroupOfSingers")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdUser")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAuthor");

                    b.HasIndex("IdChord");

                    b.HasIndex("IdCountryComposes");

                    b.HasIndex("IdGroupOfSingers");

                    b.HasIndex("IdUser");

                    b.ToTable("Song", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.SongCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdCategory")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdSong")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdSong");

                    b.ToTable("Song_Category", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.SongOfCountryCompose", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SongOfCountryComposes");
                });

            modelBuilder.Entity("WebChordCore.Models.SongSinger", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdSinger")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("IdSong")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdSinger");

                    b.HasIndex("IdSong");

                    b.ToTable("Song_Singer", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Tone", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tone", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdUserGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdUserGroup");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.UserGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserGroup", (string)null);
                });

            modelBuilder.Entity("WebChordCore.Models.Chord", b =>
                {
                    b.HasOne("WebChordCore.Models.ListOfImage", "IdListOfImageNavigation")
                        .WithMany("Chords")
                        .HasForeignKey("IdListOfImage")
                        .HasConstraintName("FK_Chord_ListOfImage");

                    b.Navigation("IdListOfImageNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.ChordChordGroup", b =>
                {
                    b.HasOne("WebChordCore.Models.ChordGroup", "IdChorGroupNavigation")
                        .WithMany("ChordChordGroups")
                        .HasForeignKey("IdChorGroup")
                        .HasConstraintName("FK_Chordgroup_Chord_ChordGroup");

                    b.HasOne("WebChordCore.Models.Chord", "IdChordNavigation")
                        .WithMany("ChordChordGroups")
                        .HasForeignKey("IdChord")
                        .HasConstraintName("FK_Chord_Chord_ChordGroup");

                    b.Navigation("IdChorGroupNavigation");

                    b.Navigation("IdChordNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.ChordChordType", b =>
                {
                    b.HasOne("WebChordCore.Models.ChordType", "IdChorTypeNavigation")
                        .WithMany("ChordChordTypes")
                        .HasForeignKey("IdChorType")
                        .HasConstraintName("FK_Chordgroup_Chord_ChordType");

                    b.HasOne("WebChordCore.Models.Chord", "IdChordNavigation")
                        .WithMany("ChordChordTypes")
                        .HasForeignKey("IdChord")
                        .HasConstraintName("FK_Chord_Chord_ChordType");

                    b.Navigation("IdChorTypeNavigation");

                    b.Navigation("IdChordNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.SingerTone", b =>
                {
                    b.HasOne("WebChordCore.Models.Singer", "IdSingerNavigation")
                        .WithMany("SingerTones")
                        .HasForeignKey("IdSinger")
                        .HasConstraintName("FK_Singer_Tone_Singer");

                    b.HasOne("WebChordCore.Models.Tone", "IdToneNavigation")
                        .WithMany("SingerTones")
                        .HasForeignKey("IdTone")
                        .HasConstraintName("FK_Singer_Tone_Tone");

                    b.Navigation("IdSingerNavigation");

                    b.Navigation("IdToneNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.Song", b =>
                {
                    b.HasOne("WebChordCore.Models.Author", "IdAuthorNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdAuthor")
                        .HasConstraintName("FK_Song_Author");

                    b.HasOne("WebChordCore.Models.Chord", "IdChordNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdChord")
                        .HasConstraintName("FK_Song_Chord");

                    b.HasOne("WebChordCore.Models.SongOfCountryCompose", "IdCountryComposesNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdCountryComposes")
                        .HasConstraintName("FK_Song_CountryComposes");

                    b.HasOne("WebChordCore.Models.GroupOfSinger", "IdGroupOfSingersNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdGroupOfSingers")
                        .HasConstraintName("FK_Song_GroupOfSingers");

                    b.HasOne("WebChordCore.Models.User", "IdUserNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_Song_User");

                    b.Navigation("IdAuthorNavigation");

                    b.Navigation("IdChordNavigation");

                    b.Navigation("IdCountryComposesNavigation");

                    b.Navigation("IdGroupOfSingersNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.SongCategory", b =>
                {
                    b.HasOne("WebChordCore.Models.Category", "IdCategoryNavigation")
                        .WithMany("SongCategories")
                        .HasForeignKey("IdCategory")
                        .HasConstraintName("FK_Song_Category_Category");

                    b.HasOne("WebChordCore.Models.Song", "IdSongNavigation")
                        .WithMany("SongCategories")
                        .HasForeignKey("IdSong")
                        .HasConstraintName("FK_Song_Category_Song");

                    b.Navigation("IdCategoryNavigation");

                    b.Navigation("IdSongNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.SongSinger", b =>
                {
                    b.HasOne("WebChordCore.Models.Singer", "IdSingerNavigation")
                        .WithMany("SongSingers")
                        .HasForeignKey("IdSinger")
                        .HasConstraintName("FK_Song_Singer_Singer");

                    b.HasOne("WebChordCore.Models.Song", "IdSongNavigation")
                        .WithMany("SongSingers")
                        .HasForeignKey("IdSong")
                        .HasConstraintName("FK_Song_Singer_Song");

                    b.Navigation("IdSingerNavigation");

                    b.Navigation("IdSongNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.User", b =>
                {
                    b.HasOne("WebChordCore.Models.UserGroup", "IdUserGroupNavigation")
                        .WithMany("Users")
                        .HasForeignKey("IdUserGroup")
                        .HasConstraintName("FK_User_UserGroup");

                    b.Navigation("IdUserGroupNavigation");
                });

            modelBuilder.Entity("WebChordCore.Models.Author", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WebChordCore.Models.Category", b =>
                {
                    b.Navigation("SongCategories");
                });

            modelBuilder.Entity("WebChordCore.Models.Chord", b =>
                {
                    b.Navigation("ChordChordGroups");

                    b.Navigation("ChordChordTypes");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WebChordCore.Models.ChordGroup", b =>
                {
                    b.Navigation("ChordChordGroups");
                });

            modelBuilder.Entity("WebChordCore.Models.ChordType", b =>
                {
                    b.Navigation("ChordChordTypes");
                });

            modelBuilder.Entity("WebChordCore.Models.GroupOfSinger", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WebChordCore.Models.ListOfImage", b =>
                {
                    b.Navigation("Chords");
                });

            modelBuilder.Entity("WebChordCore.Models.Singer", b =>
                {
                    b.Navigation("SingerTones");

                    b.Navigation("SongSingers");
                });

            modelBuilder.Entity("WebChordCore.Models.Song", b =>
                {
                    b.Navigation("SongCategories");

                    b.Navigation("SongSingers");
                });

            modelBuilder.Entity("WebChordCore.Models.SongOfCountryCompose", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WebChordCore.Models.Tone", b =>
                {
                    b.Navigation("SingerTones");
                });

            modelBuilder.Entity("WebChordCore.Models.User", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("WebChordCore.Models.UserGroup", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
