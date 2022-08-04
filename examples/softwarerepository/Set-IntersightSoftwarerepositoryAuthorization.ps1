# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwarerepositoryAuthorization  to Update
$SoftwarerepositoryAuthorization = Get-IntersightSoftwarerepositoryAuthorization -Moid '<Replace with Moid>'

# Update the SoftwarerepositoryAuthorization
$auth1 = $SoftwarerepositoryAuthorization | Set-IntersightSoftwarerepositoryAuthorization -RepositoryType 'Cisco'