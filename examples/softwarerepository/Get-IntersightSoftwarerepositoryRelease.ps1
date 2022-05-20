#Get the SoftwarerepositoryRelease by Name
$SoftwarerepositoryReleaseByName = Get-IntersightSoftwarerepositoryRelease -Name SoftwarerepositoryReleaseName

#Get the List of SoftwarerepositoryRelease
$SoftwarerepositoryReleaseList = Get-IntersightSoftwarerepositoryRelease

#Get the list of SoftwarerepositoryRelease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryReleaseByOrg = Get-IntersightSoftwarerepositoryRelease -Organization $org

#Get the SoftwarerepositoryRelease based on query Parameter
$SoftwarerepositoryReleaseByQueryParam = Get-IntersightSoftwarerepositoryRelease -Filter Name eq SoftwarerepositoryReleaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .