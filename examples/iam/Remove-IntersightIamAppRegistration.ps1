
#Get the IamAppRegistration to delete
$IamAppRegistration = Remove-IntersightIamAppRegistration -Name IamAppRegistrationName
$IamAppRegistration | Remove-IntersightIamAppRegistration

#Remove the server profile by Moid.
Remove-IntersightIamAppRegistration -Moid 123bc2222287wee
