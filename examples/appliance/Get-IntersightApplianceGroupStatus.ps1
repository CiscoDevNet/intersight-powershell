#Get the ApplianceGroupStatus by Name
$ApplianceGroupStatusByName = Get-IntersightApplianceGroupStatus -Name ApplianceGroupStatusName

#Get the List of ServerProfiles
$ApplianceGroupStatusList = Get-IntersightApplianceGroupStatus

#Get the list of ApplianceGroupStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceGroupStatusByOrg = Get-IntersightApplianceGroupStatus -Organization $org

#Get the ApplianceGroupStatus based on query Parameter
$ApplianceGroupStatusByQueryParam = Get-IntersightApplianceGroupStatus -Filter Name eq ApplianceGroupStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .