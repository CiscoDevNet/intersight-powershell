
#Get the OrganizationOrganization to Update
$OrganizationOrganization = Get-IntersightOrganizationOrganization -Name OrganizationOrganizationName
$OrganizationOrganization | Set-IntersightOrganizationOrganization -Description 'Updated description'
