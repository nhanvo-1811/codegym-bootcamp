SELECT * FROM [dbo].tblEmployees

ALTER TABLE dbo.tblEmployees
DROP CONSTRAINT UQ_rm

ALTER TABLE dbo.tblEmployees
ADD CONSTRAINT UQ_EmployeeName UNIQUE (EmployeeName)

ALTER TABLE dbo.tblEmployees
ADD img NVARCHAR(MAX) null 

