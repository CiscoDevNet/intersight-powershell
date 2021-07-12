
#Get the IamApiKey to delete
$IamApiKey = Remove-IntersightIamApiKey -Name IamApiKeyName
$IamApiKey | Remove-IntersightIamApiKey

#Remove the server profile by Moid.
Remove-IntersightIamApiKey -Moid 123bc2222287wee
