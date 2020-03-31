
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/14/2020 10:50:32
-- Generated from EDMX file: C:\Users\Andrei\Desktop\Facultate\TSP.NET\New folder\MyPhotos\Photos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst.Photos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ZonesMedias]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medias] DROP CONSTRAINT [FK_ZonesMedias];
GO
IF OBJECT_ID(N'[dbo].[FK_PeopleGroupsMedias]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medias] DROP CONSTRAINT [FK_PeopleGroupsMedias];
GO
IF OBJECT_ID(N'[dbo].[FK_EventsMedias]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medias] DROP CONSTRAINT [FK_EventsMedias];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Zones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zones];
GO
IF OBJECT_ID(N'[dbo].[Medias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medias];
GO
IF OBJECT_ID(N'[dbo].[PeopleGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeopleGroups];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Zones'
CREATE TABLE [dbo].[Zones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdMedia] nvarchar(max)  NOT NULL,
    [LocationName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Medias'
CREATE TABLE [dbo].[Medias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NamePhoto] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [IsDeleted] nvarchar(max)  NOT NULL,
    [ZonesId] int  NOT NULL,
    [PeopleGroupsId] int  NOT NULL,
    [EventsId] int  NOT NULL
);
GO

-- Creating table 'PeopleGroups'
CREATE TABLE [dbo].[PeopleGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdMedia] nvarchar(max)  NOT NULL,
    [PeopleName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdMedia] nvarchar(max)  NOT NULL,
    [EventName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Zones'
ALTER TABLE [dbo].[Zones]
ADD CONSTRAINT [PK_Zones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medias'
ALTER TABLE [dbo].[Medias]
ADD CONSTRAINT [PK_Medias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PeopleGroups'
ALTER TABLE [dbo].[PeopleGroups]
ADD CONSTRAINT [PK_PeopleGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ZonesId] in table 'Medias'
ALTER TABLE [dbo].[Medias]
ADD CONSTRAINT [FK_ZonesMedias]
    FOREIGN KEY ([ZonesId])
    REFERENCES [dbo].[Zones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZonesMedias'
CREATE INDEX [IX_FK_ZonesMedias]
ON [dbo].[Medias]
    ([ZonesId]);
GO

-- Creating foreign key on [PeopleGroupsId] in table 'Medias'
ALTER TABLE [dbo].[Medias]
ADD CONSTRAINT [FK_PeopleGroupsMedias]
    FOREIGN KEY ([PeopleGroupsId])
    REFERENCES [dbo].[PeopleGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PeopleGroupsMedias'
CREATE INDEX [IX_FK_PeopleGroupsMedias]
ON [dbo].[Medias]
    ([PeopleGroupsId]);
GO

-- Creating foreign key on [EventsId] in table 'Medias'
ALTER TABLE [dbo].[Medias]
ADD CONSTRAINT [FK_EventsMedias]
    FOREIGN KEY ([EventsId])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventsMedias'
CREATE INDEX [IX_FK_EventsMedias]
ON [dbo].[Medias]
    ([EventsId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------