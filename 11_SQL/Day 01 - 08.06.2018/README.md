# Home- work tasks
* download mssql 2014 from: https://www.microsoft.com/en-us/download/details.aspx?id=42299
* create a new Cinema db with this script:

```sql
USE [master]  --use the root db in the mssql
GO


CREATE DATABASE [CinemaTestDB]  --create a new DB named "CinemaTestDB"
GO
```

* create a new category table in this DB:
```sql
USE [CinemaTestDB]  --the DB that we want to add a table
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--creating "Categories" table
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
	[IsForChildren] [bit] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
```


* create a new Publishers db with this script:

```sql
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
```


* create a new Movies db with this script:

```sql
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
```



* create a new MoviesCategories db with this script:

```sql
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
```

* insert to the categories table the following data:

```sql
USE [CinemaTestDB]
GO

INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[IsForChildren])
     VALUES ('Comedy',1)
GO


INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[IsForChildren])
     VALUES ('Action',1)
GO



INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[IsForChildren])
     VALUES ('Drama',1)
GO



INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[IsForChildren])
     VALUES ('History',0)
GO

```

* ## add to the publishers table 6 records
* ## add to the movies table 20 records
* ## add to the MoviesCategories table 30 records

---
# GOOD LUCK
