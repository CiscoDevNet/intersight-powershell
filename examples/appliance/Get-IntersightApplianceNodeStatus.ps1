#Get the ApplianceNodeStatus by Name
$ApplianceNodeStatusByName = Get-IntersightApplianceNodeStatus -Name ApplianceNodeStatusName

#Get the List of ServerProfiles
$ApplianceNodeStatusList = Get-IntersightApplianceNodeStatus

#Get the list of ApplianceNodeStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceNodeStatusByOrg = Get-IntersightApplianceNodeStatus -Organization $org

#Get the ApplianceNodeStatus based on query Parameter
$ApplianceNodeStatusByQueryParam = Get-IntersightApplianceNodeStatus -Filter Name eq ApplianceNodeStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .