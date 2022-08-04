
#Get the IamResourceRoles to Update
$IamResourceRoles = Get-IntersightIamResourceRoles -Name IamResourceRolesName
$IamResourceRoles | Set-IntersightIamResourceRoles -Description 'Updated description'