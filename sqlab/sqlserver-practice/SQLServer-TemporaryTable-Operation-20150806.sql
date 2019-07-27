/*
 * File Name: SQLServer-TemporaryTable-Operation-20150806.sql
 * Description: CREATE, INSERT, QUERY, DROP temporary table in the SQL Server
 */

/* CREATE temporary table */
CREATE TABLE #ABC (
	age INT
)

/* INSERT into temporary table */
INSERT INTO #ABC VALUES (1);
INSERT INTO #ABC VALUES (2);
INSERT INTO #ABC VALUES (3);
INSERT INTO #ABC VALUES (4);

/* Query from temporary table */
SELECT * FROM #ABC

/* DELETE Operation and Query agagin */
DELETE FROM #ABC WHERE age = 4
SELECT * FROM #ABC 

/* DELETE Temporay table */
DROP TABLE #ABC