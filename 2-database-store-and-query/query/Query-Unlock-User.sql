DECLARE @return_value int
EXEC @return_value = [dbo].[aspnet_Membership_UnlockUser]
@ApplicationName = N'applicationName',
@UserName = N'user'
SELECT 'Return Value' = @return_value
GO
SELECT
	au.username, aa.ApplicationName, [password], passwordformat, passwordsalt
FROM
	aspnet_Membership am
INNER JOIN 
	aspnet_Users au ON (au.UserId = am.UserId)
INNER JOIN 
	aspnet_Applications aa ON (au.ApplicationId = aa.ApplicationId)