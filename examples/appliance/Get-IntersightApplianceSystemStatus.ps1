#Get the ApplianceSystemStatus by Name
$ApplianceSystemStatusByName = Get-IntersightApplianceSystemStatus -Name ApplianceSystemStatusName

#Get the List of ServerProfiles
$ApplianceSystemStatusList = Get-IntersightApplianceSystemStatus

#Get the list of ApplianceSystemStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceSystemStatusByOrg = Get-IntersightApplianceSystemStatus -Organization $org

#Get the ApplianceSystemStatus based on query Parameter
$ApplianceSystemStatusByQueryParam = Get-IntersightApplianceSystemStatus -Filter Name eq ApplianceSystemStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .