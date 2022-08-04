#Get the ApplianceNodeInfo by Name
$ApplianceNodeInfoByName = Get-IntersightApplianceNodeInfo -Name ApplianceNodeInfoName

#Get the List of ServerProfiles
$ApplianceNodeInfoList = Get-IntersightApplianceNodeInfo

#Get the list of ApplianceNodeInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceNodeInfoByOrg = Get-IntersightApplianceNodeInfo -Organization $org

#Get the ApplianceNodeInfo based on query Parameter
$ApplianceNodeInfoByQueryParam = Get-IntersightApplianceNodeInfo -Filter Name eq ApplianceNodeInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .