﻿ALTER TABLE [dbo].[FactOfTheDay] ADD
	[AdminUsername] NVARCHAR(128) NULL,
	[DateSubmitted]	DATETIME	  NULL,
	[DisplayCount]  INT			  NULL;

ALTER TABLE [dbo].[FactOfTheDay] ADD
	[LastDisplayed] DATETIME	NULL;