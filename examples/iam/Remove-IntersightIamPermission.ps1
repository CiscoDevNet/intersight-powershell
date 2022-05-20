
#Get the IamPermission to delete
$IamPermission = Get-IntersightIamPermission -Name IamPermissionName
$IamPermission | Remove-IntersightIamPermission

#Remove the server profile by Moid.
Remove-IntersightIamPermission -Moid '<Replace with Moid>'
