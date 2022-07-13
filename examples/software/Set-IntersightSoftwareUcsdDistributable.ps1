# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwareUcsdDistributable to Update
$SoftwareUcsdDistributable = Get-IntersightSoftwareUcsdDistributable -Name SoftwareUcsdDistributableName

# Update the SoftwareUcsdDistributable
$software_ucsd1 = $SoftwareUcsdDistributable | Set-IntersightSoftwareUcsdDistributable -Description 'update demo software ucsd distributable'