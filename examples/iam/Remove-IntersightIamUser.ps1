
#Get the IamUser to delete
$IamUser = Get-IntersightIamUser -Name IamUserName
$IamUser | Remove-IntersightIamUser

#Remove the server profile by Moid.
Remove-IntersightIamUser -Moid '<Replace with Moid>'
