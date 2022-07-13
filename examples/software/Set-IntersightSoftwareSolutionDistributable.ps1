# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwareSolutionDistributable to Update
$SoftwareSolutionDistributable = Get-IntersightSoftwareSolutionDistributable -Name SoftwareSolutionDistributableName

# Update the SoftwareSolutionDistributable
$software_solution1 = $SoftwareSolutionDistributable | Set-IntersightSoftwareSolutionDistributable -Description 'update demo software solution distributable'