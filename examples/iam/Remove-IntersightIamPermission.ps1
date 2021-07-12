
#Get the IamPermission to delete
$IamPermission = Remove-IntersightIamPermission -Name IamPermissionName
$IamPermission | Remove-IntersightIamPermission

#Remove the server profile by Moid.
Remove-IntersightIamPermission -Moid 123bc2222287wee
