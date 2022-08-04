#Get the ApplianceUpgradePolicy by Name
$ApplianceUpgradePolicyByName = Get-IntersightApplianceUpgradePolicy -Name ApplianceUpgradePolicyName

#Get the List of ServerProfiles
$ApplianceUpgradePolicyList = Get-IntersightApplianceUpgradePolicy

#Get the list of ApplianceUpgradePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceUpgradePolicyByOrg = Get-IntersightApplianceUpgradePolicy -Organization $org

#Get the ApplianceUpgradePolicy based on query Parameter
$ApplianceUpgradePolicyByQueryParam = Get-IntersightApplianceUpgradePolicy -Filter Name eq ApplianceUpgradePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .