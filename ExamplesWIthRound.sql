
SELECT ROUND(12.5,0) AS RoundToNearestWhole 
	-- Rounds to the nearest whole number, which is 12
	, ROUND(12.4999,0) AS RoundToNearestWhole
	-- Rounds to the nearest whole number, which is 12
	, ROUND(12.4999,1) AS RoundToOneDec
	-- Rounds to one decimal place, which is 12.5
	, ROUND(12.4999,-1) AS RoundToNearest10
	-- Rounds to the nearest 10, which is 10
	, ROUND(12.5,0,1) AS TruncateToNearestWhole
	-- Truncates to the nearest whole number, which is 12
	, ROUND(150.75, 0) AS RoundToNearestWhole
	-- Rounds to the nearest whole number, which is 151
	, ROUND(150.75, 0, 1) TruncateToNearestWhole
	-- Truncates to the nearest whole number, which is 150