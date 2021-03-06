USE [CBTData]
GO
/****** Object:  Table [dbo].[CBTDetailes]    Script Date: 10.08.2021 18:06:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CBTDetailes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[SubTitle] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Detailes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CBTEvents]    Script Date: 10.08.2021 18:06:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CBTEvents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CountUser] [int] NOT NULL,
	[EventCreate] [datetime] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CBTDetailes] ON 

INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (1, 1, N'Тема', N'Юбилейное событие')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (2, 3, N'Тема', N'Спорт')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (3, 1, N'местоположение', N'Кальварийская 7')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (4, 1, N'Дресс-код', N'обязателен')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (5, 2, N'Тема', N'Музыка')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (6, 2, N'подтема', N'Рок')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (7, 2, N'подтема', N'Классическая музыка')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (8, 2, N'участники', N'Певцы')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (10, 2, N'деревня', N'Иваново')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (11, 6, N'Тема', N'Учебное мероприятие')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (12, 7, N'Название', N'гшщз')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (13, 8, N'Название', N'ertyuu')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (14, 9, N'Название', N'tyuti')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (15, 10, N'Название', N'2342')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (16, 11, N'Тема', N'Участники пробега')
INSERT [dbo].[CBTDetailes] ([Id], [EventId], [Title], [SubTitle]) VALUES (17, 6, N'расписание', N'Понедельник 8-00 17-00')
SET IDENTITY_INSERT [dbo].[CBTDetailes] OFF
GO
SET IDENTITY_INSERT [dbo].[CBTEvents] ON 

INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (1, 1, 5, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (2, 1, 10, CAST(N'2021-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (3, 0, 5, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (5, 0, 123, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (6, 0, 123, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (7, 0, 111, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (8, 0, 50, CAST(N'2021-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (9, 0, 45, CAST(N'2021-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (10, 0, 12, CAST(N'2021-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CBTEvents] ([Id], [UserId], [CountUser], [EventCreate]) VALUES (11, 0, 23, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[CBTEvents] OFF
GO
