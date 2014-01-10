
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2013 23:08:22
-- Generated from EDMX file: D:\Ratraze\Custom\Custom.WebApi\Reflection\ReflectionModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [aces];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Terms'
CREATE TABLE [dbo].[Terms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Culture] varchar(16)  NOT NULL,
    [Sentence] nvarchar(max)  NOT NULL,
    [Principal_Id] int  NULL
);
GO

-- Creating table 'Domains'
CREATE TABLE [dbo].[Domains] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Term_Id] int  NOT NULL,
    [Area_Id] int  NOT NULL
);
GO

-- Creating table 'Areas'
CREATE TABLE [dbo].[Areas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Term_Id] int  NOT NULL,
    [Principal_Id] int  NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Term_Id] int  NOT NULL,
    [Domain_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Terms'
ALTER TABLE [dbo].[Terms]
ADD CONSTRAINT [PK_Terms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Domains'
ALTER TABLE [dbo].[Domains]
ADD CONSTRAINT [PK_Domains]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Term_Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [FK_TermArea]
    FOREIGN KEY ([Term_Id])
    REFERENCES [dbo].[Terms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TermArea'
CREATE INDEX [IX_FK_TermArea]
ON [dbo].[Areas]
    ([Term_Id]);
GO

-- Creating foreign key on [Term_Id] in table 'Domains'
ALTER TABLE [dbo].[Domains]
ADD CONSTRAINT [FK_TermDomain]
    FOREIGN KEY ([Term_Id])
    REFERENCES [dbo].[Terms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TermDomain'
CREATE INDEX [IX_FK_TermDomain]
ON [dbo].[Domains]
    ([Term_Id]);
GO

-- Creating foreign key on [Term_Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [FK_TermMember]
    FOREIGN KEY ([Term_Id])
    REFERENCES [dbo].[Terms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TermMember'
CREATE INDEX [IX_FK_TermMember]
ON [dbo].[Members]
    ([Term_Id]);
GO

-- Creating foreign key on [Principal_Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [FK_AreaHierarchy]
    FOREIGN KEY ([Principal_Id])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaHierarchy'
CREATE INDEX [IX_FK_AreaHierarchy]
ON [dbo].[Areas]
    ([Principal_Id]);
GO

-- Creating foreign key on [Principal_Id] in table 'Terms'
ALTER TABLE [dbo].[Terms]
ADD CONSTRAINT [FK_TermHierarchy]
    FOREIGN KEY ([Principal_Id])
    REFERENCES [dbo].[Terms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TermHierarchy'
CREATE INDEX [IX_FK_TermHierarchy]
ON [dbo].[Terms]
    ([Principal_Id]);
GO

-- Creating foreign key on [Area_Id] in table 'Domains'
ALTER TABLE [dbo].[Domains]
ADD CONSTRAINT [FK_AreaDomain]
    FOREIGN KEY ([Area_Id])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaDomain'
CREATE INDEX [IX_FK_AreaDomain]
ON [dbo].[Domains]
    ([Area_Id]);
GO

-- Creating foreign key on [Domain_Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [FK_DomainMember]
    FOREIGN KEY ([Domain_Id])
    REFERENCES [dbo].[Domains]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DomainMember'
CREATE INDEX [IX_FK_DomainMember]
ON [dbo].[Members]
    ([Domain_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------