USE [CinemaTestDB]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MoviePublishers](
	[MoviePublisherId] [int] IDENTITY(1,1) NOT NULL,
	[MoviePublisherName] [nvarchar](50) NOT NULL,
	[MoviePublisheDate] [date] NOT NULL,
 CONSTRAINT [PK_MoviePublishers] PRIMARY KEY CLUSTERED 
(
	[MoviePublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


