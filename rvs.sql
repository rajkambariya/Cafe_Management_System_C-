USE [db1]
GO

/****** Object:  Table [dbo].[tblreservation]    Script Date: 15-10-2025 08:06:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblreservation](
	[rvs_id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [int] NOT NULL,
	[Contact] [int] NOT NULL,
	[TableID] [int] NOT NULL,
	[rvsDate] [date] NOT NULL,
	[starttime] [int] NOT NULL,
	[S_am_pm] [varchar](10) NOT NULL,
	[endtime] [int] NOT NULL,
	[E_am_pm] [varchar](10) NOT NULL,
	[Guests] [int] NOT NULL,
	[rvsStatus] [bit] NOT NULL
) ON [PRIMARY]
GO


