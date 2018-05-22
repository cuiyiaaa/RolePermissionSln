
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2018 14:25:10
-- Generated from EDMX file: G:\VSProjects\2017\RolePermissionSln\Cy.RolePermission.Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Role];
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

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(32)  NULL,
    [Pwd] nvarchar(32)  NOT NULL,
    [NickName] nvarchar(64)  NOT NULL,
    [Gender] nvarchar(1)  NOT NULL,
    [Remark] nvarchar(64)  NULL,
    [CreateTime] datetime  NULL,
    [UpdateTime] datetime  NULL,
    [Status] nvarchar(1)  NOT NULL,
    [DelFlag] int  NOT NULL
);
GO

-- Creating table 'RoleInfo'
CREATE TABLE [dbo].[RoleInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(32)  NOT NULL,
    [Remark] nvarchar(64)  NULL,
    [CreateTime] datetime  NULL,
    [UpdateTime] datetime  NULL,
    [DelFlag] int  NOT NULL
);
GO

-- Creating table 'ActionInfo'
CREATE TABLE [dbo].[ActionInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ActionName] nvarchar(64)  NOT NULL,
    [Url] nvarchar(512)  NULL,
    [HttpMethd] nvarchar(32)  NULL,
    [IsMenu] bit  NOT NULL,
    [Remark] nvarchar(64)  NULL,
    [CreateTime] datetime  NOT NULL,
    [UpdateTime] datetime  NULL,
    [Sort] int  NULL,
    [DelFlag] int  NOT NULL
);
GO

-- Creating table 'R_UserInfo_ActionInfo'
CREATE TABLE [dbo].[R_UserInfo_ActionInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HasPermission] bit  NOT NULL,
    [UserInfoId] int  NOT NULL,
    [ActionInfoId] int  NOT NULL,
    [DelFlag] int  NOT NULL
);
GO

-- Creating table 'MenuInfo'
CREATE TABLE [dbo].[MenuInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Url] nvarchar(200)  NULL,
    [Iconic] nvarchar(200)  NOT NULL,
    [Sort] int  NULL,
    [Remark] nvarchar(200)  NULL,
    [State] nvarchar(20)  NOT NULL,
    [CreatePerson] nvarchar(50)  NULL,
    [CreateTime] datetime  NULL,
    [updateTime] datetime  NULL,
    [UpdatePerson] nvarchar(50)  NULL,
    [DelFlag] int  NOT NULL,
    [ActionInfo_Id] int  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(200)  NOT NULL,
    [Author] nvarchar(200)  NOT NULL,
    [PublisherId] int  NOT NULL,
    [PublishDate] datetime  NOT NULL,
    [ISBN] nvarchar(50)  NOT NULL,
    [WordsCount] int  NOT NULL,
    [UnitPrice] decimal(19,4)  NOT NULL,
    [ContentDescription] nvarchar(max)  NOT NULL,
    [AurhorDescription] nvarchar(max)  NULL,
    [EditorComment] nvarchar(max)  NULL,
    [TOC] nvarchar(max)  NULL,
    [CategoryId] int  NULL,
    [Clicks] int  NULL
);
GO

-- Creating table 'keyWordsRank'
CREATE TABLE [dbo].[keyWordsRank] (
    [Id] uniqueidentifier  NOT NULL,
    [KeyWords] nvarchar(255)  NULL,
    [SearchTimes] int  NULL
);
GO

-- Creating table 'SearchDetails'
CREATE TABLE [dbo].[SearchDetails] (
    [Id] uniqueidentifier  NOT NULL,
    [KeyWords] nvarchar(255)  NULL,
    [SearchDateTime] datetime  NULL
);
GO

-- Creating table 'Log'
CREATE TABLE [dbo].[Log] (
    [Log_Id] int IDENTITY(1,1) NOT NULL,
    [Log_DateTime] datetime  NULL,
    [User_Id] int  NOT NULL,
    [Action_Code] nvarchar(32)  NULL,
    [Operation_Type] nvarchar(8)  NOT NULL,
    [Remark] nvarchar(2000)  NULL,
    [SystemCode] nvarchar(20)  NULL,
    [ClassName] nvarchar(100)  NOT NULL,
    [UserInfoId] int  NULL
);
GO

-- Creating table 'UserInfoRoleInfo'
CREATE TABLE [dbo].[UserInfoRoleInfo] (
    [UserInfo_Id] int  NOT NULL,
    [RoleInfo_Id] int  NOT NULL
);
GO

-- Creating table 'RoleInfoActionInfo'
CREATE TABLE [dbo].[RoleInfoActionInfo] (
    [RoleInfo_Id] int  NOT NULL,
    [ActionInfo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleInfo'
ALTER TABLE [dbo].[RoleInfo]
ADD CONSTRAINT [PK_RoleInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ActionInfo'
ALTER TABLE [dbo].[ActionInfo]
ADD CONSTRAINT [PK_ActionInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [PK_R_UserInfo_ActionInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MenuInfo'
ALTER TABLE [dbo].[MenuInfo]
ADD CONSTRAINT [PK_MenuInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Title], [Author], [PublisherId], [PublishDate], [ISBN], [WordsCount], [UnitPrice], [ContentDescription] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id], [Title], [Author], [PublisherId], [PublishDate], [ISBN], [WordsCount], [UnitPrice], [ContentDescription] ASC);
GO

-- Creating primary key on [Id] in table 'keyWordsRank'
ALTER TABLE [dbo].[keyWordsRank]
ADD CONSTRAINT [PK_keyWordsRank]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SearchDetails'
ALTER TABLE [dbo].[SearchDetails]
ADD CONSTRAINT [PK_SearchDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Log_Id] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [PK_Log]
    PRIMARY KEY CLUSTERED ([Log_Id] ASC);
GO

-- Creating primary key on [UserInfo_Id], [RoleInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [PK_UserInfoRoleInfo]
    PRIMARY KEY CLUSTERED ([UserInfo_Id], [RoleInfo_Id] ASC);
GO

-- Creating primary key on [RoleInfo_Id], [ActionInfo_Id] in table 'RoleInfoActionInfo'
ALTER TABLE [dbo].[RoleInfoActionInfo]
ADD CONSTRAINT [PK_RoleInfoActionInfo]
    PRIMARY KEY CLUSTERED ([RoleInfo_Id], [ActionInfo_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_UserInfo]
    FOREIGN KEY ([UserInfo_Id])
    REFERENCES [dbo].[UserInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoleInfo_Id] in table 'UserInfoRoleInfo'
ALTER TABLE [dbo].[UserInfoRoleInfo]
ADD CONSTRAINT [FK_UserInfoRoleInfo_RoleInfo]
    FOREIGN KEY ([RoleInfo_Id])
    REFERENCES [dbo].[RoleInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoRoleInfo_RoleInfo'
CREATE INDEX [IX_FK_UserInfoRoleInfo_RoleInfo]
ON [dbo].[UserInfoRoleInfo]
    ([RoleInfo_Id]);
GO

-- Creating foreign key on [UserInfoId] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [FK_UserInfoR_UserInfo_ActionInfo]
    FOREIGN KEY ([UserInfoId])
    REFERENCES [dbo].[UserInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoR_UserInfo_ActionInfo'
CREATE INDEX [IX_FK_UserInfoR_UserInfo_ActionInfo]
ON [dbo].[R_UserInfo_ActionInfo]
    ([UserInfoId]);
GO

-- Creating foreign key on [RoleInfo_Id] in table 'RoleInfoActionInfo'
ALTER TABLE [dbo].[RoleInfoActionInfo]
ADD CONSTRAINT [FK_RoleInfoActionInfo_RoleInfo]
    FOREIGN KEY ([RoleInfo_Id])
    REFERENCES [dbo].[RoleInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ActionInfo_Id] in table 'RoleInfoActionInfo'
ALTER TABLE [dbo].[RoleInfoActionInfo]
ADD CONSTRAINT [FK_RoleInfoActionInfo_ActionInfo]
    FOREIGN KEY ([ActionInfo_Id])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleInfoActionInfo_ActionInfo'
CREATE INDEX [IX_FK_RoleInfoActionInfo_ActionInfo]
ON [dbo].[RoleInfoActionInfo]
    ([ActionInfo_Id]);
GO

-- Creating foreign key on [ActionInfoId] in table 'R_UserInfo_ActionInfo'
ALTER TABLE [dbo].[R_UserInfo_ActionInfo]
ADD CONSTRAINT [FK_ActionInfoR_UserInfo_ActionInfo]
    FOREIGN KEY ([ActionInfoId])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionInfoR_UserInfo_ActionInfo'
CREATE INDEX [IX_FK_ActionInfoR_UserInfo_ActionInfo]
ON [dbo].[R_UserInfo_ActionInfo]
    ([ActionInfoId]);
GO

-- Creating foreign key on [UserInfoId] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [FK_UserInfoLog]
    FOREIGN KEY ([UserInfoId])
    REFERENCES [dbo].[UserInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoLog'
CREATE INDEX [IX_FK_UserInfoLog]
ON [dbo].[Log]
    ([UserInfoId]);
GO

-- Creating foreign key on [ActionInfo_Id] in table 'MenuInfo'
ALTER TABLE [dbo].[MenuInfo]
ADD CONSTRAINT [FK_ActionInfoMenuInfo]
    FOREIGN KEY ([ActionInfo_Id])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionInfoMenuInfo'
CREATE INDEX [IX_FK_ActionInfoMenuInfo]
ON [dbo].[MenuInfo]
    ([ActionInfo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------