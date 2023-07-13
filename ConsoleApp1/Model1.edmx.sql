
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/13/2023 14:09:27
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

IF OBJECT_ID(N'[dbo].[FK_ProjectScreen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Screens] DROP CONSTRAINT [FK_ProjectScreen];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [FK_ProjectRole];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectBusinessRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessRules] DROP CONSTRAINT [FK_ProjectBusinessRule];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_ProjectMessage];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageBusinnesRulesMessages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinnesRulesMessages] DROP CONSTRAINT [FK_MessageBusinnesRulesMessages];
GO
IF OBJECT_ID(N'[dbo].[FK_BusinessRuleBusinnesRulesMessages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinnesRulesMessages] DROP CONSTRAINT [FK_BusinessRuleBusinnesRulesMessages];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectBusinnesRulesMessages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinnesRulesMessages] DROP CONSTRAINT [FK_ProjectBusinnesRulesMessages];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectObjectState]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectStates] DROP CONSTRAINT [FK_ProjectObjectState];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectObjectWithStates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectWithStates] DROP CONSTRAINT [FK_ProjectObjectWithStates];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectStateObjectWithStates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectWithStates] DROP CONSTRAINT [FK_ObjectStateObjectWithStates];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objects] DROP CONSTRAINT [FK_ProjectObject];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectTypeObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objects] DROP CONSTRAINT [FK_ObjectTypeObject];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectObjectWithStates]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectWithStates] DROP CONSTRAINT [FK_ObjectObjectWithStates];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectObjectStatesChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectStatesChanges] DROP CONSTRAINT [FK_ProjectObjectStatesChange];
GO
IF OBJECT_ID(N'[dbo].[FK_Predecessor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectStatesChanges] DROP CONSTRAINT [FK_Predecessor];
GO
IF OBJECT_ID(N'[dbo].[FK_Successor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectStatesChanges] DROP CONSTRAINT [FK_Successor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectObjectsForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectsForStateChanges] DROP CONSTRAINT [FK_ProjectObjectsForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectStatesChangeObjectsForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectsForStateChanges] DROP CONSTRAINT [FK_ObjectStatesChangeObjectsForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectObjectsForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectsForStateChanges] DROP CONSTRAINT [FK_ObjectObjectsForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectRolesForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolesForStateChanges] DROP CONSTRAINT [FK_ProjectRolesForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectStatesChangeRolesForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolesForStateChanges] DROP CONSTRAINT [FK_ObjectStatesChangeRolesForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleRolesForStateChange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolesForStateChanges] DROP CONSTRAINT [FK_RoleRolesForStateChange];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reports] DROP CONSTRAINT [FK_ProjectReport];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectUseCase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UseCases] DROP CONSTRAINT [FK_ProjectUseCase];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectBaseFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseFlows] DROP CONSTRAINT [FK_ProjectBaseFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlternativeFlows] DROP CONSTRAINT [FK_ProjectAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectBaseAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseAlternativeFlows] DROP CONSTRAINT [FK_ProjectBaseAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_BaseFlowBaseAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseAlternativeFlows] DROP CONSTRAINT [FK_BaseFlowBaseAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_AlternativeFlowBaseAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseAlternativeFlows] DROP CONSTRAINT [FK_AlternativeFlowBaseAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objects] DROP CONSTRAINT [FK_DiagramElementStateObject];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objects] DROP CONSTRAINT [FK_ScreenElementStateObject];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateScreen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Screens] DROP CONSTRAINT [FK_DiagramElementStateScreen];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateScreen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Screens] DROP CONSTRAINT [FK_ScreenElementStateScreen];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateBusinessRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessRules] DROP CONSTRAINT [FK_DiagramElementStateBusinessRule];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateBusinessRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BusinessRules] DROP CONSTRAINT [FK_ScreenElementStateBusinessRule];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reports] DROP CONSTRAINT [FK_DiagramElementStateReport];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reports] DROP CONSTRAINT [FK_ScreenElementStateReport];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateBaseFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseFlows] DROP CONSTRAINT [FK_DiagramElementStateBaseFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateBaseFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseFlows] DROP CONSTRAINT [FK_ScreenElementStateBaseFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramElementStateAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlternativeFlows] DROP CONSTRAINT [FK_DiagramElementStateAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenElementStateAlternativeFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlternativeFlows] DROP CONSTRAINT [FK_ScreenElementStateAlternativeFlow];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagramUseCaseState]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UseCases] DROP CONSTRAINT [FK_DiagramUseCaseState];
GO
IF OBJECT_ID(N'[dbo].[FK_ScreenUseCaseState]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UseCases] DROP CONSTRAINT [FK_ScreenUseCaseState];
GO
IF OBJECT_ID(N'[dbo].[FK_UseCaseBaseFlow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BaseFlows] DROP CONSTRAINT [FK_UseCaseBaseFlow];
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
IF OBJECT_ID(N'[dbo].[Screens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Screens];
GO
IF OBJECT_ID(N'[dbo].[ElementStates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElementStates];
GO
IF OBJECT_ID(N'[dbo].[BusinessRules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BusinessRules];
GO
IF OBJECT_ID(N'[dbo].[Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Messages];
GO
IF OBJECT_ID(N'[dbo].[BusinnesRulesMessages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BusinnesRulesMessages];
GO
IF OBJECT_ID(N'[dbo].[ObjectTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectTypes];
GO
IF OBJECT_ID(N'[dbo].[ObjectStates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectStates];
GO
IF OBJECT_ID(N'[dbo].[Prefixes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prefixes];
GO
IF OBJECT_ID(N'[dbo].[ObjectWithStates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectWithStates];
GO
IF OBJECT_ID(N'[dbo].[Objects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Objects];
GO
IF OBJECT_ID(N'[dbo].[ObjectStatesChanges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectStatesChanges];
GO
IF OBJECT_ID(N'[dbo].[ObjectsForStateChanges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectsForStateChanges];
GO
IF OBJECT_ID(N'[dbo].[RolesForStateChanges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolesForStateChanges];
GO
IF OBJECT_ID(N'[dbo].[Reports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reports];
GO
IF OBJECT_ID(N'[dbo].[UseCases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UseCases];
GO
IF OBJECT_ID(N'[dbo].[BaseFlows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BaseFlows];
GO
IF OBJECT_ID(N'[dbo].[AlternativeFlows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlternativeFlows];
GO
IF OBJECT_ID(N'[dbo].[BaseAlternativeFlows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BaseAlternativeFlows];
GO
IF OBJECT_ID(N'[dbo].[UseCaseStates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UseCaseStates];
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
    [key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Purpose] nvarchar(70)  NOT NULL,
    [ProjectId] int  NOT NULL
);
GO

-- Creating table 'Screens'
CREATE TABLE [dbo].[Screens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [ImagePath] nvarchar(max)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL
);
GO

-- Creating table 'ElementStates'
CREATE TABLE [dbo].[ElementStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BusinessRules'
CREATE TABLE [dbo].[BusinessRules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
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

-- Creating table 'ObjectTypes'
CREATE TABLE [dbo].[ObjectTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Purpose] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'ObjectStates'
CREATE TABLE [dbo].[ObjectStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [ProjectId] int  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Purpose] nvarchar(70)  NOT NULL
);
GO

-- Creating table 'Prefixes'
CREATE TABLE [dbo].[Prefixes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'ObjectWithStates'
CREATE TABLE [dbo].[ObjectWithStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [ObjectStateId] int  NOT NULL,
    [ObjectId] int  NOT NULL
);
GO

-- Creating table 'Objects'
CREATE TABLE [dbo].[Objects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [ObjectTypeId] int  NOT NULL,
    [Purpose] nvarchar(70)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL
);
GO

-- Creating table 'ObjectStatesChanges'
CREATE TABLE [dbo].[ObjectStatesChanges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [PredecessorId] int  NOT NULL,
    [SuccessorId] int  NOT NULL
);
GO

-- Creating table 'ObjectsForStateChanges'
CREATE TABLE [dbo].[ObjectsForStateChanges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [ObjectStatesChangeId] int  NOT NULL,
    [ObjectId] int  NOT NULL
);
GO

-- Creating table 'RolesForStateChanges'
CREATE TABLE [dbo].[RolesForStateChanges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [ObjectStatesChangeId] int  NOT NULL,
    [RoleId] int  NOT NULL
);
GO

-- Creating table 'Reports'
CREATE TABLE [dbo].[Reports] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [Description] nvarchar(40)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL
);
GO

-- Creating table 'UseCases'
CREATE TABLE [dbo].[UseCases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(15)  NOT NULL,
    [FlowChartPath] nvarchar(max)  NOT NULL,
    [DiagramUseCaseStateId] int  NOT NULL,
    [ScreenUseCaseStateId] int  NOT NULL
);
GO

-- Creating table 'BaseFlows'
CREATE TABLE [dbo].[BaseFlows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FlowChartPath] nvarchar(max)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL,
    [UseCaseId] int  NOT NULL
);
GO

-- Creating table 'AlternativeFlows'
CREATE TABLE [dbo].[AlternativeFlows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [FlowChartPath] nvarchar(max)  NOT NULL,
    [DiagramElementStateId] int  NOT NULL,
    [ScreenElementStateId] int  NOT NULL
);
GO

-- Creating table 'BaseAlternativeFlows'
CREATE TABLE [dbo].[BaseAlternativeFlows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] int  NOT NULL,
    [BaseFlowId] int  NOT NULL,
    [AlternativeFlowId] int  NOT NULL
);
GO

-- Creating table 'UseCaseStates'
CREATE TABLE [dbo].[UseCaseStates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'ObjectTypes'
ALTER TABLE [dbo].[ObjectTypes]
ADD CONSTRAINT [PK_ObjectTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObjectStates'
ALTER TABLE [dbo].[ObjectStates]
ADD CONSTRAINT [PK_ObjectStates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Prefixes'
ALTER TABLE [dbo].[Prefixes]
ADD CONSTRAINT [PK_Prefixes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObjectWithStates'
ALTER TABLE [dbo].[ObjectWithStates]
ADD CONSTRAINT [PK_ObjectWithStates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [PK_Objects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObjectStatesChanges'
ALTER TABLE [dbo].[ObjectStatesChanges]
ADD CONSTRAINT [PK_ObjectStatesChanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ObjectsForStateChanges'
ALTER TABLE [dbo].[ObjectsForStateChanges]
ADD CONSTRAINT [PK_ObjectsForStateChanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RolesForStateChanges'
ALTER TABLE [dbo].[RolesForStateChanges]
ADD CONSTRAINT [PK_RolesForStateChanges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [PK_Reports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UseCases'
ALTER TABLE [dbo].[UseCases]
ADD CONSTRAINT [PK_UseCases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseFlows'
ALTER TABLE [dbo].[BaseFlows]
ADD CONSTRAINT [PK_BaseFlows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlternativeFlows'
ALTER TABLE [dbo].[AlternativeFlows]
ADD CONSTRAINT [PK_AlternativeFlows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseAlternativeFlows'
ALTER TABLE [dbo].[BaseAlternativeFlows]
ADD CONSTRAINT [PK_BaseAlternativeFlows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UseCaseStates'
ALTER TABLE [dbo].[UseCaseStates]
ADD CONSTRAINT [PK_UseCaseStates]
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

-- Creating foreign key on [ProjectId] in table 'ObjectStates'
ALTER TABLE [dbo].[ObjectStates]
ADD CONSTRAINT [FK_ProjectObjectState]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectObjectState'
CREATE INDEX [IX_FK_ProjectObjectState]
ON [dbo].[ObjectStates]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'ObjectWithStates'
ALTER TABLE [dbo].[ObjectWithStates]
ADD CONSTRAINT [FK_ProjectObjectWithStates]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectObjectWithStates'
CREATE INDEX [IX_FK_ProjectObjectWithStates]
ON [dbo].[ObjectWithStates]
    ([ProjectId]);
GO

-- Creating foreign key on [ObjectStateId] in table 'ObjectWithStates'
ALTER TABLE [dbo].[ObjectWithStates]
ADD CONSTRAINT [FK_ObjectStateObjectWithStates]
    FOREIGN KEY ([ObjectStateId])
    REFERENCES [dbo].[ObjectStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectStateObjectWithStates'
CREATE INDEX [IX_FK_ObjectStateObjectWithStates]
ON [dbo].[ObjectWithStates]
    ([ObjectStateId]);
GO

-- Creating foreign key on [ProjectId] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [FK_ProjectObject]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectObject'
CREATE INDEX [IX_FK_ProjectObject]
ON [dbo].[Objects]
    ([ProjectId]);
GO

-- Creating foreign key on [ObjectTypeId] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [FK_ObjectTypeObject]
    FOREIGN KEY ([ObjectTypeId])
    REFERENCES [dbo].[ObjectTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectTypeObject'
CREATE INDEX [IX_FK_ObjectTypeObject]
ON [dbo].[Objects]
    ([ObjectTypeId]);
GO

-- Creating foreign key on [ObjectId] in table 'ObjectWithStates'
ALTER TABLE [dbo].[ObjectWithStates]
ADD CONSTRAINT [FK_ObjectObjectWithStates]
    FOREIGN KEY ([ObjectId])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectObjectWithStates'
CREATE INDEX [IX_FK_ObjectObjectWithStates]
ON [dbo].[ObjectWithStates]
    ([ObjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'ObjectStatesChanges'
ALTER TABLE [dbo].[ObjectStatesChanges]
ADD CONSTRAINT [FK_ProjectObjectStatesChange]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectObjectStatesChange'
CREATE INDEX [IX_FK_ProjectObjectStatesChange]
ON [dbo].[ObjectStatesChanges]
    ([ProjectId]);
GO

-- Creating foreign key on [PredecessorId] in table 'ObjectStatesChanges'
ALTER TABLE [dbo].[ObjectStatesChanges]
ADD CONSTRAINT [FK_Predecessor]
    FOREIGN KEY ([PredecessorId])
    REFERENCES [dbo].[ObjectStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Predecessor'
CREATE INDEX [IX_FK_Predecessor]
ON [dbo].[ObjectStatesChanges]
    ([PredecessorId]);
GO

-- Creating foreign key on [SuccessorId] in table 'ObjectStatesChanges'
ALTER TABLE [dbo].[ObjectStatesChanges]
ADD CONSTRAINT [FK_Successor]
    FOREIGN KEY ([SuccessorId])
    REFERENCES [dbo].[ObjectStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Successor'
CREATE INDEX [IX_FK_Successor]
ON [dbo].[ObjectStatesChanges]
    ([SuccessorId]);
GO

-- Creating foreign key on [ProjectId] in table 'ObjectsForStateChanges'
ALTER TABLE [dbo].[ObjectsForStateChanges]
ADD CONSTRAINT [FK_ProjectObjectsForStateChange]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectObjectsForStateChange'
CREATE INDEX [IX_FK_ProjectObjectsForStateChange]
ON [dbo].[ObjectsForStateChanges]
    ([ProjectId]);
GO

-- Creating foreign key on [ObjectStatesChangeId] in table 'ObjectsForStateChanges'
ALTER TABLE [dbo].[ObjectsForStateChanges]
ADD CONSTRAINT [FK_ObjectStatesChangeObjectsForStateChange]
    FOREIGN KEY ([ObjectStatesChangeId])
    REFERENCES [dbo].[ObjectStatesChanges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectStatesChangeObjectsForStateChange'
CREATE INDEX [IX_FK_ObjectStatesChangeObjectsForStateChange]
ON [dbo].[ObjectsForStateChanges]
    ([ObjectStatesChangeId]);
GO

-- Creating foreign key on [ObjectId] in table 'ObjectsForStateChanges'
ALTER TABLE [dbo].[ObjectsForStateChanges]
ADD CONSTRAINT [FK_ObjectObjectsForStateChange]
    FOREIGN KEY ([ObjectId])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectObjectsForStateChange'
CREATE INDEX [IX_FK_ObjectObjectsForStateChange]
ON [dbo].[ObjectsForStateChanges]
    ([ObjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'RolesForStateChanges'
ALTER TABLE [dbo].[RolesForStateChanges]
ADD CONSTRAINT [FK_ProjectRolesForStateChange]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectRolesForStateChange'
CREATE INDEX [IX_FK_ProjectRolesForStateChange]
ON [dbo].[RolesForStateChanges]
    ([ProjectId]);
GO

-- Creating foreign key on [ObjectStatesChangeId] in table 'RolesForStateChanges'
ALTER TABLE [dbo].[RolesForStateChanges]
ADD CONSTRAINT [FK_ObjectStatesChangeRolesForStateChange]
    FOREIGN KEY ([ObjectStatesChangeId])
    REFERENCES [dbo].[ObjectStatesChanges]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectStatesChangeRolesForStateChange'
CREATE INDEX [IX_FK_ObjectStatesChangeRolesForStateChange]
ON [dbo].[RolesForStateChanges]
    ([ObjectStatesChangeId]);
GO

-- Creating foreign key on [RoleId] in table 'RolesForStateChanges'
ALTER TABLE [dbo].[RolesForStateChanges]
ADD CONSTRAINT [FK_RoleRolesForStateChange]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleRolesForStateChange'
CREATE INDEX [IX_FK_RoleRolesForStateChange]
ON [dbo].[RolesForStateChanges]
    ([RoleId]);
GO

-- Creating foreign key on [ProjectId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_ProjectReport]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectReport'
CREATE INDEX [IX_FK_ProjectReport]
ON [dbo].[Reports]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'UseCases'
ALTER TABLE [dbo].[UseCases]
ADD CONSTRAINT [FK_ProjectUseCase]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectUseCase'
CREATE INDEX [IX_FK_ProjectUseCase]
ON [dbo].[UseCases]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'BaseFlows'
ALTER TABLE [dbo].[BaseFlows]
ADD CONSTRAINT [FK_ProjectBaseFlow]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectBaseFlow'
CREATE INDEX [IX_FK_ProjectBaseFlow]
ON [dbo].[BaseFlows]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'AlternativeFlows'
ALTER TABLE [dbo].[AlternativeFlows]
ADD CONSTRAINT [FK_ProjectAlternativeFlow]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectAlternativeFlow'
CREATE INDEX [IX_FK_ProjectAlternativeFlow]
ON [dbo].[AlternativeFlows]
    ([ProjectId]);
GO

-- Creating foreign key on [ProjectId] in table 'BaseAlternativeFlows'
ALTER TABLE [dbo].[BaseAlternativeFlows]
ADD CONSTRAINT [FK_ProjectBaseAlternativeFlow]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Projects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectBaseAlternativeFlow'
CREATE INDEX [IX_FK_ProjectBaseAlternativeFlow]
ON [dbo].[BaseAlternativeFlows]
    ([ProjectId]);
GO

-- Creating foreign key on [BaseFlowId] in table 'BaseAlternativeFlows'
ALTER TABLE [dbo].[BaseAlternativeFlows]
ADD CONSTRAINT [FK_BaseFlowBaseAlternativeFlow]
    FOREIGN KEY ([BaseFlowId])
    REFERENCES [dbo].[BaseFlows]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BaseFlowBaseAlternativeFlow'
CREATE INDEX [IX_FK_BaseFlowBaseAlternativeFlow]
ON [dbo].[BaseAlternativeFlows]
    ([BaseFlowId]);
GO

-- Creating foreign key on [AlternativeFlowId] in table 'BaseAlternativeFlows'
ALTER TABLE [dbo].[BaseAlternativeFlows]
ADD CONSTRAINT [FK_AlternativeFlowBaseAlternativeFlow]
    FOREIGN KEY ([AlternativeFlowId])
    REFERENCES [dbo].[AlternativeFlows]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlternativeFlowBaseAlternativeFlow'
CREATE INDEX [IX_FK_AlternativeFlowBaseAlternativeFlow]
ON [dbo].[BaseAlternativeFlows]
    ([AlternativeFlowId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [FK_DiagramElementStateObject]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateObject'
CREATE INDEX [IX_FK_DiagramElementStateObject]
ON [dbo].[Objects]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [FK_ScreenElementStateObject]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateObject'
CREATE INDEX [IX_FK_ScreenElementStateObject]
ON [dbo].[Objects]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [FK_DiagramElementStateScreen]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateScreen'
CREATE INDEX [IX_FK_DiagramElementStateScreen]
ON [dbo].[Screens]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [FK_ScreenElementStateScreen]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateScreen'
CREATE INDEX [IX_FK_ScreenElementStateScreen]
ON [dbo].[Screens]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [FK_DiagramElementStateBusinessRule]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateBusinessRule'
CREATE INDEX [IX_FK_DiagramElementStateBusinessRule]
ON [dbo].[BusinessRules]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'BusinessRules'
ALTER TABLE [dbo].[BusinessRules]
ADD CONSTRAINT [FK_ScreenElementStateBusinessRule]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateBusinessRule'
CREATE INDEX [IX_FK_ScreenElementStateBusinessRule]
ON [dbo].[BusinessRules]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_DiagramElementStateReport]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateReport'
CREATE INDEX [IX_FK_DiagramElementStateReport]
ON [dbo].[Reports]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_ScreenElementStateReport]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateReport'
CREATE INDEX [IX_FK_ScreenElementStateReport]
ON [dbo].[Reports]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'BaseFlows'
ALTER TABLE [dbo].[BaseFlows]
ADD CONSTRAINT [FK_DiagramElementStateBaseFlow]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateBaseFlow'
CREATE INDEX [IX_FK_DiagramElementStateBaseFlow]
ON [dbo].[BaseFlows]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'BaseFlows'
ALTER TABLE [dbo].[BaseFlows]
ADD CONSTRAINT [FK_ScreenElementStateBaseFlow]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateBaseFlow'
CREATE INDEX [IX_FK_ScreenElementStateBaseFlow]
ON [dbo].[BaseFlows]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramElementStateId] in table 'AlternativeFlows'
ALTER TABLE [dbo].[AlternativeFlows]
ADD CONSTRAINT [FK_DiagramElementStateAlternativeFlow]
    FOREIGN KEY ([DiagramElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramElementStateAlternativeFlow'
CREATE INDEX [IX_FK_DiagramElementStateAlternativeFlow]
ON [dbo].[AlternativeFlows]
    ([DiagramElementStateId]);
GO

-- Creating foreign key on [ScreenElementStateId] in table 'AlternativeFlows'
ALTER TABLE [dbo].[AlternativeFlows]
ADD CONSTRAINT [FK_ScreenElementStateAlternativeFlow]
    FOREIGN KEY ([ScreenElementStateId])
    REFERENCES [dbo].[ElementStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenElementStateAlternativeFlow'
CREATE INDEX [IX_FK_ScreenElementStateAlternativeFlow]
ON [dbo].[AlternativeFlows]
    ([ScreenElementStateId]);
GO

-- Creating foreign key on [DiagramUseCaseStateId] in table 'UseCases'
ALTER TABLE [dbo].[UseCases]
ADD CONSTRAINT [FK_DiagramUseCaseState]
    FOREIGN KEY ([DiagramUseCaseStateId])
    REFERENCES [dbo].[UseCaseStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagramUseCaseState'
CREATE INDEX [IX_FK_DiagramUseCaseState]
ON [dbo].[UseCases]
    ([DiagramUseCaseStateId]);
GO

-- Creating foreign key on [ScreenUseCaseStateId] in table 'UseCases'
ALTER TABLE [dbo].[UseCases]
ADD CONSTRAINT [FK_ScreenUseCaseState]
    FOREIGN KEY ([ScreenUseCaseStateId])
    REFERENCES [dbo].[UseCaseStates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenUseCaseState'
CREATE INDEX [IX_FK_ScreenUseCaseState]
ON [dbo].[UseCases]
    ([ScreenUseCaseStateId]);
GO

-- Creating foreign key on [UseCaseId] in table 'BaseFlows'
ALTER TABLE [dbo].[BaseFlows]
ADD CONSTRAINT [FK_UseCaseBaseFlow]
    FOREIGN KEY ([UseCaseId])
    REFERENCES [dbo].[UseCases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UseCaseBaseFlow'
CREATE INDEX [IX_FK_UseCaseBaseFlow]
ON [dbo].[BaseFlows]
    ([UseCaseId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------