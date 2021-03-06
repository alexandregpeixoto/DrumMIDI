/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [DrumMidiDatabase]
GO
/****** Object:  Table [dbo].[tbDrumPart]    Script Date: 19/10/2017 23:05:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDrumPart](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[intensity] [bigint] NULL,
	[analogPort] [bigint] NULL,
	[idNote] [bigint] NULL,
 CONSTRAINT [PK_tbDrumPart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNote]    Script Date: 19/10/2017 23:05:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNote](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[codeMIDI] [bigint] NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_tbNote] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPreset]    Script Date: 19/10/2017 23:05:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPreset](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[presetName] [varchar](50) NOT NULL,
	[idPart1] [bigint] NULL,
	[idPart2] [bigint] NULL,
	[idPart3] [bigint] NULL,
	[idPart4] [bigint] NULL,
	[idPart5] [bigint] NULL,
	[idUser] [bigint] NOT NULL,
 CONSTRAINT [PK_tbPreset] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 19/10/2017 23:05:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUser](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_tbUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbDrumPart] ON 

INSERT [dbo].[tbDrumPart] ([id], [intensity], [analogPort], [idNote]) VALUES (1, 100, 1, 1)
INSERT [dbo].[tbDrumPart] ([id], [intensity], [analogPort], [idNote]) VALUES (2, 100, 2, 2)
INSERT [dbo].[tbDrumPart] ([id], [intensity], [analogPort], [idNote]) VALUES (3, 100, 3, 3)
INSERT [dbo].[tbDrumPart] ([id], [intensity], [analogPort], [idNote]) VALUES (4, 100, 4, 4)
INSERT [dbo].[tbDrumPart] ([id], [intensity], [analogPort], [idNote]) VALUES (5, 100, 5, 5)
SET IDENTITY_INSERT [dbo].[tbDrumPart] OFF
SET IDENTITY_INSERT [dbo].[tbNote] ON 

INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (1, 35, N'Bombo 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (2, 36, N'Bombo 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (3, 37, N'Batida no Aro')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (4, 38, N'Tarola 1 Pele')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (5, 39, N'Palmas')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (6, 40, N'Tarola 2 Aro')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (7, 41, N'Timbalão grave 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (8, 42, N'Pratos de choque fechados')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (9, 43, N'Timbalão grave 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (10, 44, N'Pratos de choque fechados pedal')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (11, 45, N'Timbalão médio 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (12, 46, N'Pratos de choque abertos')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (13, 47, N'Timbalão médio 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (14, 48, N'Timbalão agudo 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (15, 49, N'Prato de ataque crash 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (16, 50, N'Timbalão agudo 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (17, 51, N'Prato de condução 1')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (18, 52, N'Prato de ataque china')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (19, 53, N'Prato de condução')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (20, 54, N'Pandeirola')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (21, 55, N'Prato de ataque splash')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (22, 56, N'Caneca')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (23, 57, N'Prato de ataque crash 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (24, 58, N'Vibraslap')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (25, 59, N'Prato de condução 2')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (26, 60, N'Bongo agudo')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (27, 61, N'Bongo grave')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (28, 62, N'Conga aguda abafada')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (29, 63, N'Conga aguda')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (30, 64, N'Conga grave')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (31, 65, N'Timbale agudo')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (32, 66, N'Timbale grave')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (33, 67, N'Agogô')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (34, 68, N'Agogô grave')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (35, 69, N'Afoxé')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (36, 70, N'Maracas')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (37, 71, N'Apito curto')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (38, 72, N'Apito longo')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (39, 73, N'Reco-reco curto')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (40, 74, N'Reco-reco longo')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (41, 75, N'Clavas')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (42, 76, N'Bloco de madeira agudo')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (43, 77, N'Bloco de madeira grave')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (44, 78, N'Cuíca abafada')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (45, 79, N'Cuíca')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (46, 80, N'Triângulo abafado')
INSERT [dbo].[tbNote] ([id], [codeMIDI], [name]) VALUES (47, 81, N'Triângulo')
SET IDENTITY_INSERT [dbo].[tbNote] OFF
SET IDENTITY_INSERT [dbo].[tbPreset] ON 

INSERT [dbo].[tbPreset] ([id], [presetName], [idPart1], [idPart2], [idPart3], [idPart4], [idPart5], [idUser]) VALUES (1, N'Template', 1, 2, 3, 4, 5, 1)
SET IDENTITY_INSERT [dbo].[tbPreset] OFF
SET IDENTITY_INSERT [dbo].[tbUser] ON 

INSERT [dbo].[tbUser] ([id], [name], [password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[tbUser] OFF
ALTER TABLE [dbo].[tbDrumPart]  WITH CHECK ADD  CONSTRAINT [FK_tbDrumPart_tbNote] FOREIGN KEY([idNote])
REFERENCES [dbo].[tbNote] ([id])
GO
ALTER TABLE [dbo].[tbDrumPart] CHECK CONSTRAINT [FK_tbDrumPart_tbNote]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbDrumPart1] FOREIGN KEY([idPart1])
REFERENCES [dbo].[tbDrumPart] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbDrumPart1]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbDrumPart2] FOREIGN KEY([idPart2])
REFERENCES [dbo].[tbDrumPart] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbDrumPart2]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbDrumPart3] FOREIGN KEY([idPart3])
REFERENCES [dbo].[tbDrumPart] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbDrumPart3]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbDrumPart4] FOREIGN KEY([idPart4])
REFERENCES [dbo].[tbDrumPart] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbDrumPart4]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbDrumPart5] FOREIGN KEY([idPart5])
REFERENCES [dbo].[tbDrumPart] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbDrumPart5]
GO
ALTER TABLE [dbo].[tbPreset]  WITH CHECK ADD  CONSTRAINT [FK_tbPreset_tbUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[tbUser] ([id])
GO
ALTER TABLE [dbo].[tbPreset] CHECK CONSTRAINT [FK_tbPreset_tbUser]
GO
