#Get the OsBulkInstallInfo by Name
$OsBulkInstallInfoByName = Get-IntersightOsBulkInstallInfo -Name OsBulkInstallInfoName

#Get the List of ServerProfiles
$OsBulkInstallInfoList = Get-IntersightOsBulkInstallInfo

#Get the list of OsBulkInstallInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$OsBulkInstallInfoByOrg = Get-IntersightOsBulkInstallInfo -Organization $org

#Get the OsBulkInstallInfo based on query Parameter
$OsBulkInstallInfoByQueryParam = Get-IntersightOsBulkInstallInfo -Filter Name eq OsBulkInstallInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .