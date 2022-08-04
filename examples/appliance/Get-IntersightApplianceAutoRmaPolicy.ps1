#Get the ApplianceAutoRmaPolicy by Name
$ApplianceAutoRmaPolicyByName = Get-IntersightApplianceAutoRmaPolicy -Name ApplianceAutoRmaPolicyName

#Get the List of ServerProfiles
$ApplianceAutoRmaPolicyList = Get-IntersightApplianceAutoRmaPolicy

#Get the list of ApplianceAutoRmaPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceAutoRmaPolicyByOrg = Get-IntersightApplianceAutoRmaPolicy -Organization $org

#Get the ApplianceAutoRmaPolicy based on query Parameter
$ApplianceAutoRmaPolicyByQueryParam = Get-IntersightApplianceAutoRmaPolicy -Filter Name eq ApplianceAutoRmaPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .