
#Get the OrganizationOrganization to delete
$OrganizationOrganization = Remove-IntersightOrganizationOrganization -Name OrganizationOrganizationName
$OrganizationOrganization | Remove-IntersightOrganizationOrganization

#Remove the server profile by Moid.
Remove-IntersightOrganizationOrganization -Moid 123bc2222287wee
