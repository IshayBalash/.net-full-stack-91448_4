USE [CinemaTestDB]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](50) NOT NULL,
	[MoviePublisherId] [int] NOT NULL,
	[MoviePublisheTime] [datetime] NULL,
	[MoviePrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Movies] ADD  CONSTRAINT [DF_Movies_MoviePrice]  DEFAULT ((10)) FOR [MoviePrice]
GO

ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_MoviePublishers] FOREIGN KEY([MoviePublisherId])
REFERENCES [dbo].[MoviePublishers] ([MoviePublisherId])
GO

ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_MoviePublishers]
GO


