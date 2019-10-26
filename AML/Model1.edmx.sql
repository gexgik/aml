
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/26/2019 14:48:56
-- Generated from EDMX file: D:\aml\aml\AML\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AMLDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Shareholder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shareholder];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Company'
CREATE TABLE [dbo].[Company] (
    [Id] int  NOT NULL,
    [Name] nchar(10)  NULL,
    [CUI] nchar(10)  NULL,
    [Sales] decimal(18,0)  NULL,
    [Profit] decimal(18,0)  NULL,
    [Shareholders] nvarchar(max)  NULL,
    [Percentages] nvarchar(max)  NULL
);
GO

-- Creating table 'Shareholder'
CREATE TABLE [dbo].[Shareholder] (
    [Id] int  NOT NULL,
    [FirstName] nchar(10)  NULL,
    [LastName] nchar(10)  NULL,
    [CNP] nchar(10)  NULL,
    [Age] smallint  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [PK_Company]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Shareholder'
ALTER TABLE [dbo].[Shareholder]
ADD CONSTRAINT [PK_Shareholder]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------