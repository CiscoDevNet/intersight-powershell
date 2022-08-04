#Get the SoftwarerepositoryDownloadSpec by Name
$SoftwarerepositoryDownloadSpecByName = Get-IntersightSoftwarerepositoryDownloadSpec -Name SoftwarerepositoryDownloadSpecName

#Get the List of ServerProfiles
$SoftwarerepositoryDownloadSpecList = Get-IntersightSoftwarerepositoryDownloadSpec

#Get the list of SoftwarerepositoryDownloadSpec under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwarerepositoryDownloadSpecByOrg = Get-IntersightSoftwarerepositoryDownloadSpec -Organization $org

#Get the SoftwarerepositoryDownloadSpec based on query Parameter
$SoftwarerepositoryDownloadSpecByQueryParam = Get-IntersightSoftwarerepositoryDownloadSpec -Filter Name eq SoftwarerepositoryDownloadSpecName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .