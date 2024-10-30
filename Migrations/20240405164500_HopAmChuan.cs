using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChordCore.Migrations
{
    public partial class HopAmChuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ComposerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChordGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChordGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupOfSinger",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfMembers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOfSinger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuestsWatch",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestsWatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListOfImage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Singer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SongOfCountryComposes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongOfCountryComposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tone",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chord",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyNo = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdListOfImage = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chord_ListOfImage",
                        column: x => x.IdListOfImage,
                        principalTable: "ListOfImage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Singer_Tone",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdSinger = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdTone = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singer_Tone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Singer_Tone_Singer",
                        column: x => x.IdSinger,
                        principalTable: "Singer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Singer_Tone_Tone",
                        column: x => x.IdTone,
                        principalTable: "Tone",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdUserGroup = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserGroup",
                        column: x => x.IdUserGroup,
                        principalTable: "UserGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chord_ChordGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdChord = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdChorGroup = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chord_ChordGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chord_Chord_ChordGroup",
                        column: x => x.IdChord,
                        principalTable: "Chord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chordgroup_Chord_ChordGroup",
                        column: x => x.IdChorGroup,
                        principalTable: "ChordGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chord_ChordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdChord = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdChorType = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chord_ChordType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chord_Chord_ChordType",
                        column: x => x.IdChord,
                        principalTable: "Chord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chordgroup_Chord_ChordType",
                        column: x => x.IdChorType,
                        principalTable: "ChordType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    IdChord = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdAuthor = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdCountryComposes = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdGroupOfSingers = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdUser = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Activity = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Author",
                        column: x => x.IdAuthor,
                        principalTable: "Author",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_Chord",
                        column: x => x.IdChord,
                        principalTable: "Chord",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_CountryComposes",
                        column: x => x.IdCountryComposes,
                        principalTable: "SongOfCountryComposes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_GroupOfSingers",
                        column: x => x.IdGroupOfSingers,
                        principalTable: "GroupOfSinger",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_User",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Song_Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdSong = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdCategory = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Category_Category",
                        column: x => x.IdCategory,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_Category_Song",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Song_Singer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    IdSong = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IdSinger = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Singer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Singer_Singer",
                        column: x => x.IdSinger,
                        principalTable: "Singer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Song_Singer_Song",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chord_IdListOfImage",
                table: "Chord",
                column: "IdListOfImage");

            migrationBuilder.CreateIndex(
                name: "IX_Chord_ChordGroup_IdChord",
                table: "Chord_ChordGroup",
                column: "IdChord");

            migrationBuilder.CreateIndex(
                name: "IX_Chord_ChordGroup_IdChorGroup",
                table: "Chord_ChordGroup",
                column: "IdChorGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Chord_ChordType_IdChord",
                table: "Chord_ChordType",
                column: "IdChord");

            migrationBuilder.CreateIndex(
                name: "IX_Chord_ChordType_IdChorType",
                table: "Chord_ChordType",
                column: "IdChorType");

            migrationBuilder.CreateIndex(
                name: "IX_Singer_Tone_IdSinger",
                table: "Singer_Tone",
                column: "IdSinger");

            migrationBuilder.CreateIndex(
                name: "IX_Singer_Tone_IdTone",
                table: "Singer_Tone",
                column: "IdTone");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdAuthor",
                table: "Song",
                column: "IdAuthor");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdChord",
                table: "Song",
                column: "IdChord");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdCountryComposes",
                table: "Song",
                column: "IdCountryComposes");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdGroupOfSingers",
                table: "Song",
                column: "IdGroupOfSingers");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdUser",
                table: "Song",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Category_IdCategory",
                table: "Song_Category",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Category_IdSong",
                table: "Song_Category",
                column: "IdSong");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Singer_IdSinger",
                table: "Song_Singer",
                column: "IdSinger");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Singer_IdSong",
                table: "Song_Singer",
                column: "IdSong");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdUserGroup",
                table: "User",
                column: "IdUserGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chord_ChordGroup");

            migrationBuilder.DropTable(
                name: "Chord_ChordType");

            migrationBuilder.DropTable(
                name: "GuestsWatch");

            migrationBuilder.DropTable(
                name: "Singer_Tone");

            migrationBuilder.DropTable(
                name: "Song_Category");

            migrationBuilder.DropTable(
                name: "Song_Singer");

            migrationBuilder.DropTable(
                name: "ChordGroup");

            migrationBuilder.DropTable(
                name: "ChordType");

            migrationBuilder.DropTable(
                name: "Tone");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Singer");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Chord");

            migrationBuilder.DropTable(
                name: "SongOfCountryComposes");

            migrationBuilder.DropTable(
                name: "GroupOfSinger");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ListOfImage");

            migrationBuilder.DropTable(
                name: "UserGroup");
        }
    }
}
