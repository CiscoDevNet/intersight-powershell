#Get the SoftwareDownloadHistory by Name
$SoftwareDownloadHistoryByName = Get-IntersightSoftwareDownloadHistory -Name SoftwareDownloadHistoryName

#Get the List of ServerProfiles
$SoftwareDownloadHistoryList = Get-IntersightSoftwareDownloadHistory

#Get the list of SoftwareDownloadHistory under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwareDownloadHistoryByOrg = Get-IntersightSoftwareDownloadHistory -Organization $org

#Get the SoftwareDownloadHistory based on query Parameter
$SoftwareDownloadHistoryByQueryParam = Get-IntersightSoftwareDownloadHistory -Filter Name eq SoftwareDownloadHistoryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .