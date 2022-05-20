
#Get the IamAppRegistration to delete
$IamAppRegistration = Get-IntersightIamAppRegistration -Name IamAppRegistrationName
$IamAppRegistration | Remove-IntersightIamAppRegistration

#Remove the server profile by Moid.
Remove-IntersightIamAppRegistration -Moid '<Replace with Moid>'
