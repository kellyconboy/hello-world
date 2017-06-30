/* NewsItem Table Creation Script */
CREATE TABLE [dbo].[NewsItem] (
    [Id]             INT IDENTITY (1, 1) NOT NULL,
    [Category]       VARCHAR (10)  NULL,
    [Organization]   VARCHAR (50)  NULL,
    [Title]          VARCHAR (50)  NOT NULL,
    [LinkTitle]      VARCHAR (100) NULL,
    [Description]    VARCHAR (MAX) NULL,
    [DateCreated]    DATETIME      NULL,
    [DateModified]   DATETIME      NULL,
    [CreatedBy]      VARCHAR (50)  NULL,
    [ModifiedBy]     VARCHAR (50)  NULL,
    [DisplayItem]    BIT           NOT NULL,
    [ArchiveDate]    DATETIME      NULL,
    CONSTRAINT [dbo.PK_NewsAlert] PRIMARY KEY CLUSTERED ([Id] ASC)
);

/* NewsItem View Creation Script */

CREATE VIEW ActiveNewsItem AS
SELECT  Id, DisplayItem, Category, Organization, Title, LinkTitle, Description
FROM dbo.NewsItem
WHERE (DisplayItem = 1) AND (ArchiveDate IS NULL)
ORDER BY Title
