
#Get the IamOAuthToken to Update
$IamOAuthToken = Get-IntersightIamOAuthToken -Name IamOAuthTokenName
$IamOAuthToken | Set-IntersightIamOAuthToken -Description 'Updated description'