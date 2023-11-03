USE [studentInfo]
GO

/****** Object:  Table [dbo].[thirdYear]    Script Date: 01/11/2023 3:42:58 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[thirdYear](
	[gradeLevel] [varchar](50) NULL,
	[semester] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[LRN] [int] NOT NULL,
	[status] [varchar](50) NULL,
	[schoolYear] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[firstName] [varchar](50) NULL,
	[middleName] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[dateBirth] [varchar](50) NULL,
	[civilStatus] [varchar](50) NULL,
	[citizenship] [varchar](50) NULL,
	[religion] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[ZIP] [varchar](50) NULL,
	[contactNumber] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[guardianName] [varchar](50) NULL,
	[guardianContact] [varchar](50) NULL,
	[currentlastSchool] [varchar](50) NULL,
 CONSTRAINT [PK_thirdYear] PRIMARY KEY CLUSTERED 
(
	[LRN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

