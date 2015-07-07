
--DROP Table [dbo].[PlayerTable]

CREATE TABLE [dbo].[PlayerTable] (
    [Rank]           INT            NOT NULL,
    [Name]         VARCHAR (50)   NOT NULL,
    [Team]           VARCHAR (50)   NOT NULL,
    [Position]       VARCHAR (50)   NOT NULL,
    [Games]          INT            DEFAULT ((0)) NOT NULL,
    [AtBats]         INT            DEFAULT ((0)) NOT NULL,
    [Runs]           INT            DEFAULT ((0)) NOT NULL,
    [Hits]           INT            DEFAULT ((0)) NOT NULL,
    [SecondBase]        INT            NOT NULL,
    [ThirdBase]        INT            NOT NULL,
    [HomeRuns]             INT            DEFAULT ((0)) NOT NULL,
    [RunsBattedIn]            INT            DEFAULT ((0)) NOT NULL,
    [BattedBall]     INT            NOT NULL,
    [StrikeOuts]     INT            NOT NULL,
    [StolenBase]     INT            NOT NULL,
    [CaughtStealing] INT            NOT NULL,
    [BattingAverage] DECIMAL (4, 3) DEFAULT ((0.000)) NOT NULL,
    CONSTRAINT [PK_PlayerTable] PRIMARY KEY CLUSTERED ([Name] ASC),
);

