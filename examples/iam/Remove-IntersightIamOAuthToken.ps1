
#Get the IamOAuthToken to delete
$IamOAuthToken = Get-IntersightIamOAuthToken -Name IamOAuthTokenName
$IamOAuthToken | Remove-IntersightIamOAuthToken

#Remove the server profile by Moid.
Remove-IntersightIamOAuthToken -Moid '<Replace with Moid>'
