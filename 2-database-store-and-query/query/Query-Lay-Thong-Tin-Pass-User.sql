SELECT
	au.username, aa.ApplicationName, [password], passwordformat, passwordsalt
FROM
	aspnet_Membership am
INNER JOIN 
	aspnet_Users au ON (au.UserId = am.UserId)
INNER JOIN 
	aspnet_Applications aa ON (au.ApplicationId = aa.ApplicationId)
WHERE
	au.UserName = 'admin'