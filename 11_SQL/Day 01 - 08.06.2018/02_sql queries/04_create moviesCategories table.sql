USE [CinemaTestDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MoviesCategories](
	[MovieCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_MoviesCategories] PRIMARY KEY CLUSTERED 
(
	[MovieCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MoviesCategories]  WITH CHECK ADD  CONSTRAINT [FK_MoviesCategories_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO

ALTER TABLE [dbo].[MoviesCategories] CHECK CONSTRAINT [FK_MoviesCategories_Categories]
GO

ALTER TABLE [dbo].[MoviesCategories]  WITH CHECK ADD  CONSTRAINT [FK_MoviesCategories_Movies] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movies] ([MovieId])
GO

ALTER TABLE [dbo].[MoviesCategories] CHECK CONSTRAINT [FK_MoviesCategories_Movies]
GO


