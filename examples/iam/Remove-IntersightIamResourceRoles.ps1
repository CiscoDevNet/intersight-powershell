
#Get the IamResourceRoles to delete
$IamResourceRoles = Remove-IntersightIamResourceRoles -Name IamResourceRolesName
$IamResourceRoles | Remove-IntersightIamResourceRoles

#Remove the server profile by Moid.
Remove-IntersightIamResourceRoles -Moid 123bc2222287wee
