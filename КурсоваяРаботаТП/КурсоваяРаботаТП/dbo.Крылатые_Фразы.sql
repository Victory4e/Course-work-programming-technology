CREATE TABLE [dbo].[Крылатые_Фразы] (
    [Номер]          INT            IDENTITY (1, 1) NOT NULL,
    [Крылатая_Фраза] NVARCHAR (MAX) NOT NULL,
    [Тип_Фразы]      NVARCHAR (50)  NULL,
    [Источник]       NVARCHAR (50)  NULL,
    [Автор]          NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Номер] ASC)
);

