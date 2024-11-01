USE [HopAmChuan]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ComposerName] [nvarchar](max) NULL,
	[AuthorName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chord]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chord](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[KeyNo] [char](10) NULL,
	[IdListOfImage] [int] NULL,
 CONSTRAINT [PK_Chord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chord_ChordGroup]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chord_ChordGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdChord] [int] NULL,
	[IdChorGroup] [int] NULL,
 CONSTRAINT [PK_Chord_ChordGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chord_ChordType]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chord_ChordType](
	[Id] [char](10) NOT NULL,
	[IdChord] [int] NULL,
	[IdChorType] [int] NULL,
 CONSTRAINT [PK_Chord_ChordType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChordGroup]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChordGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChordGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChordType]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChordType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChordType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupOfSinger]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupOfSinger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NumberOfMembers] [int] NULL,
 CONSTRAINT [PK_GroupOfSinger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestsWatch]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestsWatch](
	[Id] [char](10) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Phone] [char](20) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_GuestWatch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListOfImage]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListOfImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Url] [nvarchar](max) NULL,
 CONSTRAINT [PK_ListOfImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Singer]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Singer](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Singer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Singer_Tone]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Singer_Tone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSinger] [int] NULL,
	[IdTone] [int] NULL,
 CONSTRAINT [PK_Singer_Tone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Song]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Content] [ntext] NULL,
	[IdChord] [int] NULL,
	[IdAuthor] [int] NULL,
	[IdCountryComposes] [int] NULL,
	[IdGroupOfSingers] [int] NULL,
	[IdUser] [int] NULL,
	[Activity] [bit] NULL,
	[Url] [nvarchar](255) NULL,
	[Tag] [nvarchar](500) NULL,
	[Date] [datetime] NULL,
	[Link] [ntext] NULL,
 CONSTRAINT [PK_Song] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Song_Category]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song_Category](
	[Id] [int] NOT NULL,
	[IdSong] [int] NULL,
	[IdCategory] [int] NULL,
 CONSTRAINT [PK_Song_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Song_Singer]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song_Singer](
	[Id] [int] NOT NULL,
	[IdSong] [int] NULL,
	[IdSinger] [int] NULL,
 CONSTRAINT [PK_Song_Singer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SongOfCountryComposes]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SongOfCountryComposes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_SongOfCountryComposes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tone]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](max) NULL,
	[UserName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[IdUserGroup] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 4/19/2024 2:22:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [ComposerName], [AuthorName]) VALUES (1, NULL, N'Sơn Tùng')
INSERT [dbo].[Author] ([Id], [ComposerName], [AuthorName]) VALUES (2, NULL, N'Đan Trường')
INSERT [dbo].[Author] ([Id], [ComposerName], [AuthorName]) VALUES (3, NULL, N'a')
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Nhạc Trẻ')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Nhạc Trữ tình')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Nhạc Vàng')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Nhạc Quê hương')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (5, N'Nhạc Đỏ')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (6, N'Nhạc Dân ca')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (7, N'Nhạc Quốc tế')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (8, N'Nhạc Học trò')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (9, N'Nhạc Thiếu nhi')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (10, N'Nhạc Thánh ca')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (11, N'Nhạc Phật giáo')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Chord] ON 

INSERT [dbo].[Chord] ([Id], [Name], [KeyNo], [IdListOfImage]) VALUES (1, N'Mi trưởng', NULL, NULL)
INSERT [dbo].[Chord] ([Id], [Name], [KeyNo], [IdListOfImage]) VALUES (2, N'Đô trưởng', NULL, NULL)
INSERT [dbo].[Chord] ([Id], [Name], [KeyNo], [IdListOfImage]) VALUES (3, N'a', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Chord] OFF
GO
INSERT [dbo].[Singer] ([Id], [Name]) VALUES (1, N'Đan trường')
INSERT [dbo].[Singer] ([Id], [Name]) VALUES (2, N'Sơn tùng')
GO
INSERT [dbo].[Song] ([Id], [Name], [Content], [IdChord], [IdAuthor], [IdCountryComposes], [IdGroupOfSingers], [IdUser], [Activity], [Url], [Tag], [Date], [Link]) VALUES (1, N'Kiếp ve sầu', N'<p>Từ khi {Am} &nbsp;em kh&ocirc;ng c&ograve;n về quanh s&acirc;n</p>

<p>L&agrave; lần con {F} phố nghe hoang vắng v&ocirc; {C} c&ugrave;ng</p>

<p>Ng&agrave;n {F} &aacute;nh nắng lấp l&aacute;nh bước {G} theo em đang biến nơi {C} n&agrave;o. {E7}</p>

<p>&nbsp;</p>

<p>Ng&agrave;y chia {Am} ly kh&ocirc;ng c&ograve;n g&igrave; trong tay</p>

<p>Chỉ c&ograve;n nỗi {F} nhớ với anh suốt đ&ecirc;m {C} d&agrave;i</p>

<p>C&oacute; con {F} s&oacute;ng ngo&agrave;i khơi tr&agrave;n v&agrave;o thuyền {Em} anh cuốn đi rồi</p>

<p>{F} Những ước {G} mơ sau {Am} c&ugrave;ng.</p>

<p>&nbsp;</p>

<p>Ng&agrave;y chia {Am} tay anh một đời r&ecirc;u phong</p>

<p>Một lần sau {F} cuối cho anh thấy mặt {C} người</p>

<p>Cuộc {F} sống vẫn tiếp nối vắng {G} xa nhau anh sống v&ocirc; {C} chừng. {E7}</p>

<p>C&ograve;n g&igrave; {Am} đ&acirc;u khi d&ograve;ng đời chia hai</p>

<p>Chỉ c&ograve;n nước {F} mắt &ocirc;m anh đến mu&ocirc;n {C} đời</p>

<p>Những đ&ecirc;m {F} tối triền mi&ecirc;n</p>

<p>C&ograve;n một m&igrave;nh {Em} anh tiếc thương ho&agrave;i</p>

<p>Những dấu {G} y&ecirc;u trong {Am} đời.</p>

<p>&nbsp;</p>

<p>ĐK:</p>

<p>{Dm} Anh y&ecirc;u em y&ecirc;u say {G} đắm</p>

<p>Kh&ocirc;ng cần toan t&iacute;nh nghĩ suy l&agrave;m {Am} chi</p>

<p>{F} Anh y&ecirc;u em sao chua {G} x&oacute;t l&atilde;ng qu&ecirc;n {C} th&aacute;ng năm. {E7}</p>

<p>&nbsp;</p>

<p>Chờ ng&agrave;y em {Am} đến tiếng h&aacute;t v&uacute;t {Em} cao</p>

<p>Chỉ c&ograve;n tia {Dm} nắng ấm &aacute;p b&ecirc;n {Am} đời</p>

<p>C&ugrave;ng ng&agrave;n m&acirc;y {F} trắng lững lờ v&uacute;t {G} cao bay l&ecirc;n chốn {C} xa. {E7}</p>

<p>&nbsp;</p>

<p>Một ng&agrave;y em {Am} đến g&oacute;c phố h&aacute;t {Em} ca</p>

<p>Từng đ&agrave;n chim {Dm} &eacute;n ch&uacute;m ch&iacute;m m&ocirc;i {Am} cười</p>

<p>L&agrave; đời anh {F} bớt mệt nho&agrave;i</p>

<p>H&aacute;t {G} rong trong kiếp ve {Am} sầu.</p>
', 1, 1, 1, NULL, NULL, 1, N'Kiep-ve-sau', NULL, CAST(N'2024-02-26T01:08:17.330' AS DateTime), N'https://www.youtube.com/embed/ccCig7MGs_g?si=q-M1Rw7f7R8YTIib')
GO
INSERT [dbo].[Song_Category] ([Id], [IdSong], [IdCategory]) VALUES (1, 1, 1)
GO
INSERT [dbo].[Song_Singer] ([Id], [IdSong], [IdSinger]) VALUES (1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[SongOfCountryComposes] ON 

INSERT [dbo].[SongOfCountryComposes] ([Id], [Name]) VALUES (1, N'Việt Nam')
SET IDENTITY_INSERT [dbo].[SongOfCountryComposes] OFF
GO
INSERT [dbo].[User] ([Id], [Name], [DienThoai], [Email], [Address], [UserName], [Password], [IdUserGroup]) VALUES (1, N'Triệu Vân', N'1', N'admin@gmail.com', N'Vũng tàu', N'admin', N'admin', 1)
GO
INSERT [dbo].[UserGroup] ([Id], [Name]) VALUES (1, N'Admin')
GO
ALTER TABLE [dbo].[Chord]  WITH CHECK ADD  CONSTRAINT [FK_Chord_ListOfImage] FOREIGN KEY([IdListOfImage])
REFERENCES [dbo].[ListOfImage] ([Id])
GO
ALTER TABLE [dbo].[Chord] CHECK CONSTRAINT [FK_Chord_ListOfImage]
GO
ALTER TABLE [dbo].[Chord_ChordGroup]  WITH CHECK ADD  CONSTRAINT [FK_Chord_Chord_ChordGroup] FOREIGN KEY([IdChord])
REFERENCES [dbo].[Chord] ([Id])
GO
ALTER TABLE [dbo].[Chord_ChordGroup] CHECK CONSTRAINT [FK_Chord_Chord_ChordGroup]
GO
ALTER TABLE [dbo].[Chord_ChordGroup]  WITH CHECK ADD  CONSTRAINT [FK_Chordgroup_Chord_ChordGroup] FOREIGN KEY([IdChorGroup])
REFERENCES [dbo].[ChordGroup] ([Id])
GO
ALTER TABLE [dbo].[Chord_ChordGroup] CHECK CONSTRAINT [FK_Chordgroup_Chord_ChordGroup]
GO
ALTER TABLE [dbo].[Chord_ChordType]  WITH CHECK ADD  CONSTRAINT [FK_Chord_Chord_ChordType] FOREIGN KEY([IdChord])
REFERENCES [dbo].[Chord] ([Id])
GO
ALTER TABLE [dbo].[Chord_ChordType] CHECK CONSTRAINT [FK_Chord_Chord_ChordType]
GO
ALTER TABLE [dbo].[Chord_ChordType]  WITH CHECK ADD  CONSTRAINT [FK_Chordgroup_Chord_ChordType] FOREIGN KEY([IdChorType])
REFERENCES [dbo].[ChordType] ([Id])
GO
ALTER TABLE [dbo].[Chord_ChordType] CHECK CONSTRAINT [FK_Chordgroup_Chord_ChordType]
GO
ALTER TABLE [dbo].[Singer_Tone]  WITH CHECK ADD  CONSTRAINT [FK_Singer_Tone_Singer] FOREIGN KEY([IdSinger])
REFERENCES [dbo].[Singer] ([Id])
GO
ALTER TABLE [dbo].[Singer_Tone] CHECK CONSTRAINT [FK_Singer_Tone_Singer]
GO
ALTER TABLE [dbo].[Singer_Tone]  WITH CHECK ADD  CONSTRAINT [FK_Singer_Tone_Tone] FOREIGN KEY([IdTone])
REFERENCES [dbo].[Tone] ([Id])
GO
ALTER TABLE [dbo].[Singer_Tone] CHECK CONSTRAINT [FK_Singer_Tone_Tone]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_Author] FOREIGN KEY([IdAuthor])
REFERENCES [dbo].[Author] ([Id])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_Author]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_Chord] FOREIGN KEY([IdChord])
REFERENCES [dbo].[Chord] ([Id])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_Chord]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_CountryComposes] FOREIGN KEY([IdCountryComposes])
REFERENCES [dbo].[SongOfCountryComposes] ([Id])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_CountryComposes]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_GroupOfSingers] FOREIGN KEY([IdGroupOfSingers])
REFERENCES [dbo].[GroupOfSinger] ([Id])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_GroupOfSingers]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_User]
GO
ALTER TABLE [dbo].[Song_Category]  WITH CHECK ADD  CONSTRAINT [FK_Song_Category_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Song_Category] CHECK CONSTRAINT [FK_Song_Category_Category]
GO
ALTER TABLE [dbo].[Song_Category]  WITH CHECK ADD  CONSTRAINT [FK_Song_Category_Song] FOREIGN KEY([IdSong])
REFERENCES [dbo].[Song] ([Id])
GO
ALTER TABLE [dbo].[Song_Category] CHECK CONSTRAINT [FK_Song_Category_Song]
GO
ALTER TABLE [dbo].[Song_Singer]  WITH CHECK ADD  CONSTRAINT [FK_Song_Singer] FOREIGN KEY([IdSong])
REFERENCES [dbo].[Song] ([Id])
GO
ALTER TABLE [dbo].[Song_Singer] CHECK CONSTRAINT [FK_Song_Singer]
GO
ALTER TABLE [dbo].[Song_Singer]  WITH CHECK ADD  CONSTRAINT [FK_Song_Singer_Singer] FOREIGN KEY([IdSinger])
REFERENCES [dbo].[Singer] ([Id])
GO
ALTER TABLE [dbo].[Song_Singer] CHECK CONSTRAINT [FK_Song_Singer_Singer]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserGroup] FOREIGN KEY([IdUserGroup])
REFERENCES [dbo].[UserGroup] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserGroup]
GO
