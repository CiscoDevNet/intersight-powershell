
#Get the IamApiKey to delete
$IamApiKey = Get-IntersightIamApiKey -Name IamApiKeyName
$IamApiKey | Remove-IntersightIamApiKey

#Remove the server profile by Moid.
Remove-IntersightIamApiKey -Moid '<Replace with Moid>'
