#Get the SoftwarerepositoryOperatingSystemFile by Name
$SoftwarerepositoryOperatingSystemFileByName = Get-IntersightSoftwarerepositoryOperatingSystemFile -Name SoftwarerepositoryOperatingSystemFileName

#Get the List of SoftwarerepositoryOperatingSystemFile
$SoftwarerepositoryOperatingSystemFileList = Get-IntersightSoftwarerepositoryOperatingSystemFile

#Get the list of SoftwarerepositoryOperatingSystemFile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryOperatingSystemFileByOrg = Get-IntersightSoftwarerepositoryOperatingSystemFile -Organization $org

#Get the SoftwarerepositoryOperatingSystemFile based on query Parameter
$SoftwarerepositoryOperatingSystemFileByQueryParam = Get-IntersightSoftwarerepositoryOperatingSystemFile -Filter Name eq SoftwarerepositoryOperatingSystemFileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .