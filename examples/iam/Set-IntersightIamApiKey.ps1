
#Get the IamApiKey to Update
$IamApiKey = Get-IntersightIamApiKey -Name IamApiKeyName
$IamApiKey | Set-IntersightIamApiKey -Description 'Updated description'