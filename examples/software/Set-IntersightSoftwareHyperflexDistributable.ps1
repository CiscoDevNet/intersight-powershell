# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwareHyperflexDistributable to Update
$SoftwareHyperflexDistributable = Get-IntersightSoftwareHyperflexDistributable -Name SoftwareHyperflexDistributableName

# Update the SoftwareHyperflexDistributable
$hyperflex1 = $SoftwareHyperflexDistributable | Set-IntersightSoftwareHyperflexDistributable -Description 'update demo software hyperflex distributable'