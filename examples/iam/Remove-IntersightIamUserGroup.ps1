
#Get the IamUserGroup to delete
$IamUserGroup = Remove-IntersightIamUserGroup -Name IamUserGroupName
$IamUserGroup | Remove-IntersightIamUserGroup

#Remove the server profile by Moid.
Remove-IntersightIamUserGroup -Moid 123bc2222287wee
