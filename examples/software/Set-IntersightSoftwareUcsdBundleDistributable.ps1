# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwareUcsdBundleDistributable to Update
$SoftwareUcsdBundleDistributable = Get-IntersightSoftwareUcsdBundleDistributable -Name SoftwareUcsdBundleDistributableName

# Update the SoftwareUcsdBundleDistributable
$software_ucsd1 = $SoftwareUcsdBundleDistributable | Set-IntersightSoftwareUcsdBundleDistributable -Description 'update demo software ucsd bundle distributable'