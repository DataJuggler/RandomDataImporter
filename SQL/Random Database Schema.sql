USE [RandomData]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[StreetAddress] [nvarchar](255) NOT NULL,
	[Unit] [nvarchar](10) NULL,
	[City] [nvarchar](50) NOT NULL,
	[StateId] [int] NOT NULL,
	[ZipCode] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](25) NOT NULL,
	[LastName] [nvarchar](25) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Code] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MemberAddressView]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MemberAddressView]
AS
SELECT dbo.Member.Id AS MemberId, dbo.Member.FirstName, dbo.Member.LastName, dbo.Address.Id AS AddressId, dbo.Address.StreetAddress, dbo.Address.Unit, dbo.Address.City, dbo.Address.StateId, dbo.State.Name AS StateName, dbo.State.Code AS StateCode, dbo.Address.ZipCode
FROM  dbo.Member INNER JOIN
        dbo.Address ON dbo.Member.Id = dbo.Address.MemberId INNER JOIN
        dbo.State ON dbo.Address.StateId = dbo.State.Id
GO
/****** Object:  Table [dbo].[Adjective]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adjective](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WordText] [nvarchar](40) NOT NULL,
	[Syllables] [int] NOT NULL,
 CONSTRAINT [PK_Adjective] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adverb]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adverb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WordText] [nvarchar](40) NOT NULL,
	[Syllables] [int] NOT NULL,
 CONSTRAINT [PK_Adverb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FirstName]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirstName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_FirstName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LastName]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LastName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_LastName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Noun]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Noun](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WordText] [nvarchar](40) NOT NULL,
	[Syllables] [int] NOT NULL,
 CONSTRAINT [PK_Noun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StreetName]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StreetName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_StreetAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Verb]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Verb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WordText] [nvarchar](40) NOT NULL,
	[Syllables] [int] NOT NULL,
 CONSTRAINT [PK_Verb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZipCode]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZipCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
	[StateId] [int] NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_ZipCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [DF_Member_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Member]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_State] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_State]
GO
ALTER TABLE [dbo].[ZipCode]  WITH CHECK ADD  CONSTRAINT [FK_ZipCode_State] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
ALTER TABLE [dbo].[ZipCode] CHECK CONSTRAINT [FK_ZipCode_State]
GO
/****** Object:  StoredProcedure [dbo].[Address_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Address_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Address]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Address_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Address_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [City],[Id],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [Address]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Address_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Address_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [City],[Id],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [Address]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Address_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Address_Insert]

    -- Add the parameters for the stored procedure here
    @City nvarchar(50),
    @MemberId int,
    @StateId int,
    @StreetAddress nvarchar(255),
    @Unit nvarchar(10),
    @ZipCode nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Address]
    ([City],[MemberId],[StateId],[StreetAddress],[Unit],[ZipCode])

    -- Begin Values List
    Values(@City, @MemberId, @StateId, @StreetAddress, @Unit, @ZipCode)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Address_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Address_Update]

    -- Add the parameters for the stored procedure here
    @City nvarchar(50),
    @Id int,
    @MemberId int,
    @StateId int,
    @StreetAddress nvarchar(255),
    @Unit nvarchar(10),
    @ZipCode nvarchar(10)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Address]

    -- Update Each field
    Set [City] = @City,
    [MemberId] = @MemberId,
    [StateId] = @StateId,
    [StreetAddress] = @StreetAddress,
    [Unit] = @Unit,
    [ZipCode] = @ZipCode

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adjective_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adjective_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Adjective]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adjective_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adjective_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Adjective]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adjective_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adjective_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Adjective]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adjective_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adjective_Insert]

    -- Add the parameters for the stored procedure here
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Adjective]
    ([Syllables],[WordText])

    -- Begin Values List
    Values(@Syllables, @WordText)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adjective_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adjective_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Adjective]

    -- Update Each field
    Set [Syllables] = @Syllables,
    [WordText] = @WordText

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adverb_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adverb_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Adverb]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adverb_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adverb_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Adverb]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adverb_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adverb_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Adverb]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adverb_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adverb_Insert]

    -- Add the parameters for the stored procedure here
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Adverb]
    ([Syllables],[WordText])

    -- Begin Values List
    Values(@Syllables, @WordText)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Adverb_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Adverb_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Adverb]

    -- Update Each field
    Set [Syllables] = @Syllables,
    [WordText] = @WordText

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[FirstName_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[FirstName_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [FirstName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[FirstName_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[FirstName_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [FirstName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[FirstName_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[FirstName_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [FirstName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[FirstName_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[FirstName_Insert]

    -- Add the parameters for the stored procedure here
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [FirstName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[FirstName_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[FirstName_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [FirstName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LastName_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[LastName_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [LastName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LastName_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[LastName_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [LastName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LastName_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[LastName_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [LastName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LastName_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[LastName_Insert]

    -- Add the parameters for the stored procedure here
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [LastName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LastName_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[LastName_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [LastName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Member_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Member_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Member]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Member_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Member_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[FirstName],[Id],[LastName]

    -- From tableName
    From [Member]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Member_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Member_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[FirstName],[Id],[LastName]

    -- From tableName
    From [Member]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Member_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Member_Insert]

    -- Add the parameters for the stored procedure here
    @Active bit,
    @FirstName nvarchar(25),
    @LastName nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Member]
    ([Active],[FirstName],[LastName])

    -- Begin Values List
    Values(@Active, @FirstName, @LastName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Member_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Member_Update]

    -- Add the parameters for the stored procedure here
    @Active bit,
    @FirstName nvarchar(25),
    @Id int,
    @LastName nvarchar(25)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Member]

    -- Update Each field
    Set [Active] = @Active,
    [FirstName] = @FirstName,
    [LastName] = @LastName

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[MemberAddressView_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[MemberAddressView_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AddressId],[City],[FirstName],[LastName],[MemberId],[StateCode],[StateId],[StateName],[StreetAddress],[Unit],[ZipCode]

    -- From tableName
    From [MemberAddressView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Noun_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Noun_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Noun]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Noun_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Noun_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Noun]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Noun_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Noun_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Noun]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Noun_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Noun_Insert]

    -- Add the parameters for the stored procedure here
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Noun]
    ([Syllables],[WordText])

    -- Begin Values List
    Values(@Syllables, @WordText)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Noun_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Noun_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Noun]

    -- Update Each field
    Set [Syllables] = @Syllables,
    [WordText] = @WordText

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[State_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [State]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[State_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[State_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[State_FindByName]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_FindByName]

    -- Create @Name Paramater
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Code],[Id],[Name]

    -- From tableName
    From [State]

    -- Find Matching Record
    Where [Name] = @Name

END


-- End Custom Methods

-- Thank you for using DataTier.Net.

GO
/****** Object:  StoredProcedure [dbo].[State_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_Insert]

    -- Add the parameters for the stored procedure here
    @Code nvarchar(10),
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [State]
    ([Code],[Name])

    -- Begin Values List
    Values(@Code, @Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[State_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[State_Update]

    -- Add the parameters for the stored procedure here
    @Code nvarchar(10),
    @Id int,
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [State]

    -- Update Each field
    Set [Code] = @Code,
    [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[StreetName_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[StreetName_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [StreetName]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[StreetName_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[StreetName_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [StreetName]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[StreetName_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[StreetName_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name]

    -- From tableName
    From [StreetName]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[StreetName_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[StreetName_Insert]

    -- Add the parameters for the stored procedure here
    @Name nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [StreetName]
    ([Name])

    -- Begin Values List
    Values(@Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[StreetName_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[StreetName_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [StreetName]

    -- Update Each field
    Set [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Verb_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Verb_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Verb]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Verb_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Verb_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Verb]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Verb_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Verb_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Syllables],[WordText]

    -- From tableName
    From [Verb]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Verb_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Verb_Insert]

    -- Add the parameters for the stored procedure here
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Verb]
    ([Syllables],[WordText])

    -- Begin Values List
    Values(@Syllables, @WordText)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Verb_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Verb_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Syllables int,
    @WordText nvarchar(40)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Verb]

    -- Update Each field
    Set [Syllables] = @Syllables,
    [WordText] = @WordText

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ZipCode_Delete]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ZipCode_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ZipCode]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ZipCode_FetchAll]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ZipCode_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CityName],[Id],[Name],[StateId]

    -- From tableName
    From [ZipCode]

END

-- Thank you for using DataTier.Net.

GO
/****** Object:  StoredProcedure [dbo].[ZipCode_Find]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ZipCode_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CityName],[Id],[Name],[StateId]

    -- From tableName
    From [ZipCode]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ZipCode_Insert]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ZipCode_Insert]

    -- Add the parameters for the stored procedure here
    @CityName nvarchar(50),
    @Name nvarchar(10),
    @StateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ZipCode]
    ([CityName],[Name],[StateId])

    -- Begin Values List
    Values(@CityName, @Name, @StateId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ZipCode_Update]    Script Date: 4/18/2021 5:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ZipCode_Update]

    -- Add the parameters for the stored procedure here
    @CityName nvarchar(50),
    @Id int,
    @Name nvarchar(10),
    @StateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ZipCode]

    -- Update Each field
    Set [CityName] = @CityName,
    [Name] = @Name,
    [StateId] = @StateId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
