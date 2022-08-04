#Get the ApplianceSystemInfo by Name
$ApplianceSystemInfoByName = Get-IntersightApplianceSystemInfo -Name ApplianceSystemInfoName

#Get the List of ServerProfiles
$ApplianceSystemInfoList = Get-IntersightApplianceSystemInfo

#Get the list of ApplianceSystemInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceSystemInfoByOrg = Get-IntersightApplianceSystemInfo -Organization $org

#Get the ApplianceSystemInfo based on query Parameter
$ApplianceSystemInfoByQueryParam = Get-IntersightApplianceSystemInfo -Filter Name eq ApplianceSystemInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .