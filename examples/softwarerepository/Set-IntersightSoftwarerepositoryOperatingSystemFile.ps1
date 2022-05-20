# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the SoftwarerepositoryOperatingSystemFile  to Update
$SoftwarerepositoryOperatingSystemFile = Get-IntersightSoftwarerepositoryOperatingSystemFile -Name SoftwarerepositoryOperatingSystemFileName

# Update the SoftwarerepositoryOperatingSystemFile
$operating_system_file1 = $SoftwarerepositoryOperatingSystemFile | Set-IntersightSoftwarerepositoryOperatingSystemFile -Description 'update osf1'