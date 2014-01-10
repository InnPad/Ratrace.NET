
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2013 23:09:01
-- Generated from EDMX file: D:\Ratraze\Custom\Custom.WebApi\Social\SocialModel.edmx
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

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Author_Id] int  NOT NULL
);
GO

-- Creating table 'Identities'
CREATE TABLE [dbo].[Identities] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Identity_Id] int  NOT NULL,
    [Circle_Id] int  NOT NULL
);
GO

-- Creating table 'Circles'
CREATE TABLE [dbo].[Circles] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Exchanges'
CREATE TABLE [dbo].[Exchanges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SentOn] datetime  NOT NULL,
    [SeenOn] datetime  NOT NULL,
    [Message_Id] int  NOT NULL,
    [Recipient_Id] int  NOT NULL,
    [Sender_Id] int  NOT NULL
);
GO

-- Creating table 'Broadcasts'
CREATE TABLE [dbo].[Broadcasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SentOn] datetime  NOT NULL,
    [Circle_Id] int  NOT NULL,
    [Message_Id] int  NOT NULL,
    [Sender_Id] int  NOT NULL
);
GO

-- Creating table 'Sessions'
CREATE TABLE [dbo].[Sessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Since] datetime  NOT NULL,
    [Until] datetime  NULL,
    [Identity_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Identities'
ALTER TABLE [dbo].[Identities]
ADD CONSTRAINT [PK_Identities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Circles'
ALTER TABLE [dbo].[Circles]
ADD CONSTRAINT [PK_Circles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [PK_Exchanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Broadcasts'
ALTER TABLE [dbo].[Broadcasts]
ADD CONSTRAINT [PK_Broadcasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [PK_Sessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Identity_Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_IdentityContact]
    FOREIGN KEY ([Identity_Id])
    REFERENCES [dbo].[Identities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IdentityContact'
CREATE INDEX [IX_FK_IdentityContact]
ON [dbo].[Contacts]
    ([Identity_Id]);
GO

-- Creating foreign key on [Author_Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_IdentityMessage]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[Identities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IdentityMessage'
CREATE INDEX [IX_FK_IdentityMessage]
ON [dbo].[Messages]
    ([Author_Id]);
GO

-- Creating foreign key on [Identity_Id] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [FK_IdentitySession]
    FOREIGN KEY ([Identity_Id])
    REFERENCES [dbo].[Identities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_IdentitySession'
CREATE INDEX [IX_FK_IdentitySession]
ON [dbo].[Sessions]
    ([Identity_Id]);
GO

-- Creating foreign key on [Circle_Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_CircleContact]
    FOREIGN KEY ([Circle_Id])
    REFERENCES [dbo].[Circles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CircleContact'
CREATE INDEX [IX_FK_CircleContact]
ON [dbo].[Contacts]
    ([Circle_Id]);
GO

-- Creating foreign key on [Circle_Id] in table 'Broadcasts'
ALTER TABLE [dbo].[Broadcasts]
ADD CONSTRAINT [FK_CircleBroadcast]
    FOREIGN KEY ([Circle_Id])
    REFERENCES [dbo].[Circles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CircleBroadcast'
CREATE INDEX [IX_FK_CircleBroadcast]
ON [dbo].[Broadcasts]
    ([Circle_Id]);
GO

-- Creating foreign key on [Message_Id] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_MessageExchange]
    FOREIGN KEY ([Message_Id])
    REFERENCES [dbo].[Messages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageExchange'
CREATE INDEX [IX_FK_MessageExchange]
ON [dbo].[Exchanges]
    ([Message_Id]);
GO

-- Creating foreign key on [Message_Id] in table 'Broadcasts'
ALTER TABLE [dbo].[Broadcasts]
ADD CONSTRAINT [FK_MessageBroadcast]
    FOREIGN KEY ([Message_Id])
    REFERENCES [dbo].[Messages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageBroadcast'
CREATE INDEX [IX_FK_MessageBroadcast]
ON [dbo].[Broadcasts]
    ([Message_Id]);
GO

-- Creating foreign key on [Recipient_Id] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_ContactExchange]
    FOREIGN KEY ([Recipient_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactExchange'
CREATE INDEX [IX_FK_ContactExchange]
ON [dbo].[Exchanges]
    ([Recipient_Id]);
GO

-- Creating foreign key on [Sender_Id] in table 'Exchanges'
ALTER TABLE [dbo].[Exchanges]
ADD CONSTRAINT [FK_ContactExchange1]
    FOREIGN KEY ([Sender_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactExchange1'
CREATE INDEX [IX_FK_ContactExchange1]
ON [dbo].[Exchanges]
    ([Sender_Id]);
GO

-- Creating foreign key on [Sender_Id] in table 'Broadcasts'
ALTER TABLE [dbo].[Broadcasts]
ADD CONSTRAINT [FK_ContactBroadcast]
    FOREIGN KEY ([Sender_Id])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactBroadcast'
CREATE INDEX [IX_FK_ContactBroadcast]
ON [dbo].[Broadcasts]
    ([Sender_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------