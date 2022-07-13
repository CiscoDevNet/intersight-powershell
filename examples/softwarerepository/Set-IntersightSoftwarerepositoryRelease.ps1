# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwarerepositoryRelease  to Update
$SoftwarerepositoryRelease = Get-IntersightSoftwarerepositoryRelease -Moid '<Replace with Moid>'

# Update the SoftwarerepositoryRelease
$release1 = $SoftwarerepositoryRelease | Set-IntersightSoftwarerepositoryRelease -Type 'ComputeSystem'