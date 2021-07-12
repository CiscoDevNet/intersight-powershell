
#Get the IamUser to delete
$IamUser = Remove-IntersightIamUser -Name IamUserName
$IamUser | Remove-IntersightIamUser

#Remove the server profile by Moid.
Remove-IntersightIamUser -Moid 123bc2222287wee
