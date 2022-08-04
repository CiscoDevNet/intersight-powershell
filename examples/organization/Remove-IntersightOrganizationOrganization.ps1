
#Get the OrganizationOrganization to delete
$OrganizationOrganization = Get-IntersightOrganizationOrganization -Name OrganizationOrganizationName
$OrganizationOrganization | Remove-IntersightOrganizationOrganization

#Remove the OrganizationOrganization by Moid.
Remove-IntersightOrganizationOrganization -Moid '<Replace with Moid>'
