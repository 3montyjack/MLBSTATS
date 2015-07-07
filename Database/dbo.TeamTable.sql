--DROP TABLE [dbo].[TeamTable]

CREATE TABLE [dbo].[TeamTable] (
    [Rank]                  INT            NULL,
    [Name]                  VARCHAR (50)   NOT NULL,
    [TeamID]                VARCHAR (50)   NOT NULL,
    [League]                VARCHAR (50)   NULL,
    [Games]                 INT            NULL,
    [AtBats]                INT            NULL,
    [Runs]                  INT            DEFAULT ((0)) NULL,
    [Hits]                  INT            NULL,
    [SecondBase]               INT            NULL,
    [ThirdBase]               INT            NULL,
    [HomeRuns]              INT            DEFAULT ((0)) NULL,
    [RunsBattedIn]          INT            DEFAULT ((0)) NULL,
    [Walks]                 INT            NULL,
    [StrikeOuts]            INT            NULL,
    [StolenBases]           INT            NULL,
    [CaughtSteeling]        INT            NULL,
    [AverageBattingAverage] DECIMAL (4, 3) DEFAULT ((0.0000)) NULL,
    CONSTRAINT [PK_TeamTable] PRIMARY KEY CLUSTERED ([TeamID])
);

