
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2017 17:11:16
-- Generated from EDMX file: D:\OneDrive - Instituto Politécnico de Leiria\2_Semestre\Desevolvimento de Aplicações\Projeto\Projeto\Modelo_DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_Projeto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RefereeGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_RefereeGame];
GO
IF OBJECT_ID(N'[dbo].[FK_GameDeck1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_GameDeck1];
GO
IF OBJECT_ID(N'[dbo].[FK_GameDeck2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game] DROP CONSTRAINT [FK_GameDeck2];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckCard_Deck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeckCard] DROP CONSTRAINT [FK_DeckCard_Deck];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckCard_Card]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeckCard] DROP CONSTRAINT [FK_DeckCard_Card];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamGameTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamGameTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamGameTeam1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamGameTeam1];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeamGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamTournamentTeamGame];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardToutnamentPlayer_StandardToutnament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StandardToutnamentPlayer] DROP CONSTRAINT [FK_StandardToutnamentPlayer_StandardToutnament];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardToutnamentPlayer_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StandardToutnamentPlayer] DROP CONSTRAINT [FK_StandardToutnamentPlayer_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer] DROP CONSTRAINT [FK_TeamPlayer_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer] DROP CONSTRAINT [FK_TeamPlayer_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeam_TeamTournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamTournamentTeam] DROP CONSTRAINT [FK_TeamTournamentTeam_TeamTournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeam_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamTournamentTeam] DROP CONSTRAINT [FK_TeamTournamentTeam_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardToutnamentStandardGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_StandardToutnamentStandardGame];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_PlayerStandardGame];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandardGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_PlayerStandardGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_Referee_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Referee] DROP CONSTRAINT [FK_Referee_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_TeamGame] DROP CONSTRAINT [FK_TeamGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tournament_TeamTournament] DROP CONSTRAINT [FK_TeamTournament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardToutnament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tournament_StandardToutnament] DROP CONSTRAINT [FK_StandardToutnament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_StandardGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Game_StandardGame] DROP CONSTRAINT [FK_StandardGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrador_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Administrador] DROP CONSTRAINT [FK_Administrador_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Game]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game];
GO
IF OBJECT_ID(N'[dbo].[Deck]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deck];
GO
IF OBJECT_ID(N'[dbo].[Card]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Card];
GO
IF OBJECT_ID(N'[dbo].[Team]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Team];
GO
IF OBJECT_ID(N'[dbo].[Tournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament];
GO
IF OBJECT_ID(N'[dbo].[Player]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Player];
GO
IF OBJECT_ID(N'[dbo].[User_Referee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Referee];
GO
IF OBJECT_ID(N'[dbo].[Game_TeamGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game_TeamGame];
GO
IF OBJECT_ID(N'[dbo].[Tournament_TeamTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament_TeamTournament];
GO
IF OBJECT_ID(N'[dbo].[Tournament_StandardToutnament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tournament_StandardToutnament];
GO
IF OBJECT_ID(N'[dbo].[Game_StandardGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Game_StandardGame];
GO
IF OBJECT_ID(N'[dbo].[User_Administrador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Administrador];
GO
IF OBJECT_ID(N'[dbo].[DeckCard]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeckCard];
GO
IF OBJECT_ID(N'[dbo].[StandardToutnamentPlayer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StandardToutnamentPlayer];
GO
IF OBJECT_ID(N'[dbo].[TeamPlayer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamPlayer];
GO
IF OBJECT_ID(N'[dbo].[TeamTournamentTeam]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamTournamentTeam];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Game'
CREATE TABLE [dbo].[Game] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RefereeId] nvarchar(max)  NOT NULL,
    [DeckOneId] datetime  NOT NULL,
    [DeckTwoId] int  NOT NULL,
    [Referee_Id] int  NULL,
    [DeckOne_Id] int  NULL,
    [DeckTwo_Id] int  NULL
);
GO

-- Creating table 'Deck'
CREATE TABLE [dbo].[Deck] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Card'
CREATE TABLE [dbo].[Card] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Faction] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [Loyalty] smallint  NOT NULL,
    [Rules] nvarchar(max)  NOT NULL,
    [Attack] smallint  NOT NULL,
    [Defense] smallint  NOT NULL
);
GO

-- Creating table 'Team'
CREATE TABLE [dbo].[Team] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tournament'
CREATE TABLE [dbo].[Tournament] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Descrition] nvarchar(max)  NULL
);
GO

-- Creating table 'Player'
CREATE TABLE [dbo].[Player] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'User_Referee'
CREATE TABLE [dbo].[User_Referee] (
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Game_TeamGame'
CREATE TABLE [dbo].[Game_TeamGame] (
    [Id] int  NOT NULL,
    [TeamOne_Id] int  NULL,
    [TeamTwo_Id] int  NULL,
    [Tournament_Id] int  NOT NULL
);
GO

-- Creating table 'Tournament_TeamTournament'
CREATE TABLE [dbo].[Tournament_TeamTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Tournament_StandardToutnament'
CREATE TABLE [dbo].[Tournament_StandardToutnament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Game_StandardGame'
CREATE TABLE [dbo].[Game_StandardGame] (
    [Id] int  NOT NULL,
    [Toutnament_Id] int  NOT NULL,
    [PlayerOne_Id] int  NULL,
    [PlayerTwo_Id] int  NULL
);
GO

-- Creating table 'User_Administrador'
CREATE TABLE [dbo].[User_Administrador] (
    [email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'DeckCard'
CREATE TABLE [dbo].[DeckCard] (
    [Deck_Id] int  NOT NULL,
    [Cards_Id] int  NOT NULL
);
GO

-- Creating table 'StandardToutnamentPlayer'
CREATE TABLE [dbo].[StandardToutnamentPlayer] (
    [Toutnament_Id] int  NOT NULL,
    [Player_Id] int  NOT NULL
);
GO

-- Creating table 'TeamPlayer'
CREATE TABLE [dbo].[TeamPlayer] (
    [Team_Id] int  NOT NULL,
    [Player_Id] int  NOT NULL
);
GO

-- Creating table 'TeamTournamentTeam'
CREATE TABLE [dbo].[TeamTournamentTeam] (
    [TeamTournament_Id] int  NOT NULL,
    [Team_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [PK_Game]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deck'
ALTER TABLE [dbo].[Deck]
ADD CONSTRAINT [PK_Deck]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Card'
ALTER TABLE [dbo].[Card]
ADD CONSTRAINT [PK_Card]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [PK_Team]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament'
ALTER TABLE [dbo].[Tournament]
ADD CONSTRAINT [PK_Tournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Player'
ALTER TABLE [dbo].[Player]
ADD CONSTRAINT [PK_Player]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Referee'
ALTER TABLE [dbo].[User_Referee]
ADD CONSTRAINT [PK_User_Referee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [PK_Game_TeamGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament_TeamTournament'
ALTER TABLE [dbo].[Tournament_TeamTournament]
ADD CONSTRAINT [PK_Tournament_TeamTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tournament_StandardToutnament'
ALTER TABLE [dbo].[Tournament_StandardToutnament]
ADD CONSTRAINT [PK_Tournament_StandardToutnament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [PK_Game_StandardGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Administrador'
ALTER TABLE [dbo].[User_Administrador]
ADD CONSTRAINT [PK_User_Administrador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Deck_Id], [Cards_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [PK_DeckCard]
    PRIMARY KEY CLUSTERED ([Deck_Id], [Cards_Id] ASC);
GO

-- Creating primary key on [Toutnament_Id], [Player_Id] in table 'StandardToutnamentPlayer'
ALTER TABLE [dbo].[StandardToutnamentPlayer]
ADD CONSTRAINT [PK_StandardToutnamentPlayer]
    PRIMARY KEY CLUSTERED ([Toutnament_Id], [Player_Id] ASC);
GO

-- Creating primary key on [Team_Id], [Player_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [PK_TeamPlayer]
    PRIMARY KEY CLUSTERED ([Team_Id], [Player_Id] ASC);
GO

-- Creating primary key on [TeamTournament_Id], [Team_Id] in table 'TeamTournamentTeam'
ALTER TABLE [dbo].[TeamTournamentTeam]
ADD CONSTRAINT [PK_TeamTournamentTeam]
    PRIMARY KEY CLUSTERED ([TeamTournament_Id], [Team_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Referee_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_RefereeGame]
    FOREIGN KEY ([Referee_Id])
    REFERENCES [dbo].[User_Referee]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RefereeGame'
CREATE INDEX [IX_FK_RefereeGame]
ON [dbo].[Game]
    ([Referee_Id]);
GO

-- Creating foreign key on [DeckOne_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_GameDeck1]
    FOREIGN KEY ([DeckOne_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameDeck1'
CREATE INDEX [IX_FK_GameDeck1]
ON [dbo].[Game]
    ([DeckOne_Id]);
GO

-- Creating foreign key on [DeckTwo_Id] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [FK_GameDeck2]
    FOREIGN KEY ([DeckTwo_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameDeck2'
CREATE INDEX [IX_FK_GameDeck2]
ON [dbo].[Game]
    ([DeckTwo_Id]);
GO

-- Creating foreign key on [Deck_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Deck]
    FOREIGN KEY ([Deck_Id])
    REFERENCES [dbo].[Deck]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Cards_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Card]
    FOREIGN KEY ([Cards_Id])
    REFERENCES [dbo].[Card]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckCard_Card'
CREATE INDEX [IX_FK_DeckCard_Card]
ON [dbo].[DeckCard]
    ([Cards_Id]);
GO

-- Creating foreign key on [TeamOne_Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamGameTeam]
    FOREIGN KEY ([TeamOne_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGameTeam'
CREATE INDEX [IX_FK_TeamGameTeam]
ON [dbo].[Game_TeamGame]
    ([TeamOne_Id]);
GO

-- Creating foreign key on [TeamTwo_Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamGameTeam1]
    FOREIGN KEY ([TeamTwo_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGameTeam1'
CREATE INDEX [IX_FK_TeamGameTeam1]
ON [dbo].[Game_TeamGame]
    ([TeamTwo_Id]);
GO

-- Creating foreign key on [Tournament_Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamTournamentTeamGame]
    FOREIGN KEY ([Tournament_Id])
    REFERENCES [dbo].[Tournament_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournamentTeamGame'
CREATE INDEX [IX_FK_TeamTournamentTeamGame]
ON [dbo].[Game_TeamGame]
    ([Tournament_Id]);
GO

-- Creating foreign key on [Toutnament_Id] in table 'StandardToutnamentPlayer'
ALTER TABLE [dbo].[StandardToutnamentPlayer]
ADD CONSTRAINT [FK_StandardToutnamentPlayer_StandardToutnament]
    FOREIGN KEY ([Toutnament_Id])
    REFERENCES [dbo].[Tournament_StandardToutnament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player_Id] in table 'StandardToutnamentPlayer'
ALTER TABLE [dbo].[StandardToutnamentPlayer]
ADD CONSTRAINT [FK_StandardToutnamentPlayer_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandardToutnamentPlayer_Player'
CREATE INDEX [IX_FK_StandardToutnamentPlayer_Player]
ON [dbo].[StandardToutnamentPlayer]
    ([Player_Id]);
GO

-- Creating foreign key on [Team_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Team]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer_Player'
CREATE INDEX [IX_FK_TeamPlayer_Player]
ON [dbo].[TeamPlayer]
    ([Player_Id]);
GO

-- Creating foreign key on [TeamTournament_Id] in table 'TeamTournamentTeam'
ALTER TABLE [dbo].[TeamTournamentTeam]
ADD CONSTRAINT [FK_TeamTournamentTeam_TeamTournament]
    FOREIGN KEY ([TeamTournament_Id])
    REFERENCES [dbo].[Tournament_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Team_Id] in table 'TeamTournamentTeam'
ALTER TABLE [dbo].[TeamTournamentTeam]
ADD CONSTRAINT [FK_TeamTournamentTeam_Team]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[Team]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournamentTeam_Team'
CREATE INDEX [IX_FK_TeamTournamentTeam_Team]
ON [dbo].[TeamTournamentTeam]
    ([Team_Id]);
GO

-- Creating foreign key on [Toutnament_Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_StandardToutnamentStandardGame]
    FOREIGN KEY ([Toutnament_Id])
    REFERENCES [dbo].[Tournament_StandardToutnament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandardToutnamentStandardGame'
CREATE INDEX [IX_FK_StandardToutnamentStandardGame]
ON [dbo].[Game_StandardGame]
    ([Toutnament_Id]);
GO

-- Creating foreign key on [PlayerOne_Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_PlayerStandardGame]
    FOREIGN KEY ([PlayerOne_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardGame'
CREATE INDEX [IX_FK_PlayerStandardGame]
ON [dbo].[Game_StandardGame]
    ([PlayerOne_Id]);
GO

-- Creating foreign key on [PlayerTwo_Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_PlayerStandardGame1]
    FOREIGN KEY ([PlayerTwo_Id])
    REFERENCES [dbo].[Player]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandardGame1'
CREATE INDEX [IX_FK_PlayerStandardGame1]
ON [dbo].[Game_StandardGame]
    ([PlayerTwo_Id]);
GO

-- Creating foreign key on [Id] in table 'User_Referee'
ALTER TABLE [dbo].[User_Referee]
ADD CONSTRAINT [FK_Referee_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Game_TeamGame'
ALTER TABLE [dbo].[Game_TeamGame]
ADD CONSTRAINT [FK_TeamGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Game]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Tournament_TeamTournament'
ALTER TABLE [dbo].[Tournament_TeamTournament]
ADD CONSTRAINT [FK_TeamTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Tournament]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Tournament_StandardToutnament'
ALTER TABLE [dbo].[Tournament_StandardToutnament]
ADD CONSTRAINT [FK_StandardToutnament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Tournament]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Game_StandardGame'
ALTER TABLE [dbo].[Game_StandardGame]
ADD CONSTRAINT [FK_StandardGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Game]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'User_Administrador'
ALTER TABLE [dbo].[User_Administrador]
ADD CONSTRAINT [FK_Administrador_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------