
#Get the IamResourceRoles to delete
$IamResourceRoles = Get-IntersightIamResourceRoles -Name IamResourceRolesName
$IamResourceRoles | Remove-IntersightIamResourceRoles

#Remove the server profile by Moid.
Remove-IntersightIamResourceRoles -Moid '<Replace with Moid>'
