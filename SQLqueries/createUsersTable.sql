CREATE TABLE [dbo].[Users] (
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    [Email]    NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);