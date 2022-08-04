
#Get the IamAppRegistration to Update
$IamAppRegistration = Get-IntersightIamAppRegistration -Name IamAppRegistrationName
$IamAppRegistration | Set-IntersightIamAppRegistration -Description 'Updated description'