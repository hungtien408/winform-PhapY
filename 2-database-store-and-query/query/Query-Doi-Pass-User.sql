DECLARE @changeDate DATETIME
SET @changeDate = GETDATE()
EXEC aspnet_Membership_SetPassword
	'ApplicationName',
	'username',
	'password',
	'passwordsalt',
	@changeDate,
	passwordformat
	
-- Dung query lay thong tin roi dien thong tin user mun doi pass, 
-- set password va passwordsalt la pass minh muon doi
	