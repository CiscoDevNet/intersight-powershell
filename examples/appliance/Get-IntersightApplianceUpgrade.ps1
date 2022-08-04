#Get the ApplianceUpgrade by Name
$ApplianceUpgradeByName = Get-IntersightApplianceUpgrade -Name ApplianceUpgradeName

#Get the List of ServerProfiles
$ApplianceUpgradeList = Get-IntersightApplianceUpgrade

#Get the list of ApplianceUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceUpgradeByOrg = Get-IntersightApplianceUpgrade -Organization $org

#Get the ApplianceUpgrade based on query Parameter
$ApplianceUpgradeByQueryParam = Get-IntersightApplianceUpgrade -Filter Name eq ApplianceUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .