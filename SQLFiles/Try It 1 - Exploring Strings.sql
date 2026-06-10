--Step #3
DECLARE @charSample char(20) = 'Test'			--fixed
	, @varcharSample varchar(20) = 'Test'		--variable
	, @ncharSample nchar(20) = N'Test'			--fixed unicode
	, @nvarcharSample nvarchar(20) = N'Test'	--variable unicode

SELECT  @charSample + @varcharSample 
			+ @ncharSample + @nvarcharSample AS AllTogether
;

/*GO - batch directive is included so that you can include a 2nd declaration
of the same variables to make highlighting and executing the queries
easier without having a bunch of red squigglies. */


GO
-- Step #4
DECLARE @charSample char(10) = 'Test'
	, @varcharSample varchar(10) = 'Test'
	, @ncharSample nchar(10) = N'Test'
	, @nvarcharSample nvarchar(10) = N'Test'
	
--DATALENGTH - returns # of bytes
SELECT DATALENGTH(@charSample) AS CharBytes
	, DATALENGTH(@varcharSample) AS VarCharBytes
	, DATALENGTH(@NcharSample) AS NCharBytes
	, DATALENGTH(@NvarcharSample) AS NVarCharBytes
;
