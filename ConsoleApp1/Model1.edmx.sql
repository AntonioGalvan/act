
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/07/2023 13:41:44
-- Generated from EDMX file: D:\Repos\ACTProyecto\ConsoleApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ACTDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProjectRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_ProjectRole];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Description] nvarchar(40)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [key] int  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Purpose] nvarchar(70)  NOT NULL,
    [ProjectId] int  NOT NULL
);
GO

-- Creating table 'Screens'
CREATE TABLE [dbo].[Screens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] int  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [ImagePath] nvarchar(max)  NOT NULL,
    [ElementStateId] int  NOT NULL,
    [DiagramStateId] int  NOT NULL
);
GO

-- Creating table 'ElementStates'
CREATE TABLE [dbo].[ElementStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DiagramStates'
CREATE TABLE [dbo].[DiagramStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BusinessRules'
CREATE TABLE [dbo].[BusinessRules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DiagramStateId] int  NOT NULL,
    [ElementStateId] int  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] int  NOT NULL,
    [Description] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'BusinnesRulesMessages'
CREATE TABLE [dbo].[BusinnesRulesMessages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [MessageId] int  NOT NULL,
    [BusinessRuleId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [PK_Screens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ElementStates'
ALTER TABLE [dbo].[ElementStates]
ADD CONSTRAINT [PK_ElementStates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiagramStates'
ALTER TABLE [dbo].[DiagramStates]
ADD CONSTRAINT [PK_DiagramStates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [PK_BusinessRules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BusinnesRulesMessages'
ALTER TABLE [dbo].[BusinnesRulesMessages]
ADD CONSTRAINT [PK_BusinnesRulesMessages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProjectId] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [FK_ProjectScreen]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectScreen'
CREATE INDEX [IX_FK_ProjectScreen]
ON [dbo].[Screens]
    ([ProjectId]);
GO

-- Creating foreign key on [ElementStateId] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [FK_ElementStateScreen]
    FOREIGN KEY ([ElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ElementStateScreen'
CREATE INDEX [IX_FK_ElementStateScreen]
ON [dbo].[Screens]
    ([ElementStateId]);
GO

-- Creating foreign key on [DiagramStateId] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [FK_DiagramStateScreen]
    FOREIGN KEY ([DiagramStateId])
    REFERENCES [dbo].[DiagramStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramStateScreen'
CREATE INDEX [IX_FK_DiagramStateScreen]
ON [dbo].[Screens]
    ([DiagramStateId]);
GO

-- Creating foreign key on [ProjectId] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_ProjectRole]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectRole'
CREATE INDEX [IX_FK_ProjectRole]
ON [dbo].[Roles]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [FK_ProjectBusinessRule]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectBusinessRule'
CREATE INDEX [IX_FK_ProjectBusinessRule]
ON [dbo].[BusinessRules]
    ([ProjectId]);
GO

-- Creating foreign key on [DiagramStateId] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [FK_DiagramStateBusinessRule]
    FOREIGN KEY ([DiagramStateId])
    REFERENCES [dbo].[DiagramStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramStateBusinessRule'
CREATE INDEX [IX_FK_DiagramStateBusinessRule]
ON [dbo].[BusinessRules]
    ([DiagramStateId]);
GO

-- Creating foreign key on [ElementStateId] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [FK_ElementStateBusinessRule]
    FOREIGN KEY ([ElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ElementStateBusinessRule'
CREATE INDEX [IX_FK_ElementStateBusinessRule]
ON [dbo].[BusinessRules]
    ([ElementStateId]);
GO

-- Creating foreign key on [ProjectId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_ProjectMessage]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectMessage'
CREATE INDEX [IX_FK_ProjectMessage]
ON [dbo].[Messages]
    ([ProjectId]);
GO

-- Creating foreign key on [MessageId] in table 'BusinnesRulesMessages'
ALTER TABLE [dbo].[BusinnesRulesMessages]
ADD CONSTRAINT [FK_MessageBusinnesRulesMessages]
    FOREIGN KEY ([MessageId])
    REFERENCES [dbo].[Messages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageBusinnesRulesMessages'
CREATE INDEX [IX_FK_MessageBusinnesRulesMessages]
ON [dbo].[BusinnesRulesMessages]
    ([MessageId]);
GO

-- Creating foreign key on [BusinessRuleId] in table 'BusinnesRulesMessages'
ALTER TABLE [dbo].[BusinnesRulesMessages]
ADD CONSTRAINT [FK_BusinessRuleBusinnesRulesMessages]
    FOREIGN KEY ([BusinessRuleId])
    REFERENCES [dbo].[BusinessRules]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BusinessRuleBusinnesRulesMessages'
CREATE INDEX [IX_FK_BusinessRuleBusinnesRulesMessages]
ON [dbo].[BusinnesRulesMessages]
    ([BusinessRuleId]);
GO

-- Creating foreign key on [ProjectId] in table 'BusinnesRulesMessages'
ALTER TABLE [dbo].[BusinnesRulesMessages]
ADD CONSTRAINT [FK_ProjectBusinnesRulesMessages]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectBusinnesRulesMessages'
CREATE INDEX [IX_FK_ProjectBusinnesRulesMessages]
ON [dbo].[BusinnesRulesMessages]
    ([ProjectId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------