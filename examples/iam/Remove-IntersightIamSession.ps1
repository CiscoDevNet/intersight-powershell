
#Get the IamSession to delete
$IamSession = Remove-IntersightIamSession -Name IamSessionName
$IamSession | Remove-IntersightIamSession

#Remove the server profile by Moid.
Remove-IntersightIamSession -Moid 123bc2222287wee
