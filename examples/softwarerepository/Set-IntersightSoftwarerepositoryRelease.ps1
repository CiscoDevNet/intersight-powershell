# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the SoftwarerepositoryRelease  to Update
$SoftwarerepositoryRelease = Get-IntersightSoftwarerepositoryRelease -Moid '<Replace with Moid>'

# Update the SoftwarerepositoryRelease
$release1 = $SoftwarerepositoryRelease | Set-IntersightSoftwarerepositoryRelease -Type 'ComputeSystem'