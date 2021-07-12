
#Get the IamOAuthToken to delete
$IamOAuthToken = Remove-IntersightIamOAuthToken -Name IamOAuthTokenName
$IamOAuthToken | Remove-IntersightIamOAuthToken

#Remove the server profile by Moid.
Remove-IntersightIamOAuthToken -Moid 123bc2222287wee
