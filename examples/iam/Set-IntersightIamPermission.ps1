
#Get the IamPermission to Update
$IamPermission = Get-IntersightIamPermission -Name IamPermissionName
$IamPermission | Set-IntersightIamPermission -Description 'Updated description'