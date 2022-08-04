#Get the ApplianceAppStatus by Name
$ApplianceAppStatusByName = Get-IntersightApplianceAppStatus -Name ApplianceAppStatusName

#Get the List of ServerProfiles
$ApplianceAppStatusList = Get-IntersightApplianceAppStatus

#Get the list of ApplianceAppStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceAppStatusByOrg = Get-IntersightApplianceAppStatus -Organization $org

#Get the ApplianceAppStatus based on query Parameter
$ApplianceAppStatusByQueryParam = Get-IntersightApplianceAppStatus -Filter Name eq ApplianceAppStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .