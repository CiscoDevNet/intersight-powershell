
#Get the IamUserGroup to delete
$IamUserGroup = Get-IntersightIamUserGroup -Name IamUserGroupName
$IamUserGroup | Remove-IntersightIamUserGroup

#Remove the server profile by Moid.
Remove-IntersightIamUserGroup -Moid '<Replace with Moid>'
