/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
[CategoryId]
,[ID]
,[ImageUrl]
      ,[Description]
      ,[Showorder]
      ,CreateDate
      ,[UpdateDate]
      
      --,[StartDate]
      --,[EndDate]
      
  FROM [TWSQLDB].[dbo].[GreetingWords]
  where CategoryId='2'
  order by Showorder