#Get the ApplianceDataExportPolicy by Name
$ApplianceDataExportPolicyByName = Get-IntersightApplianceDataExportPolicy -Name ApplianceDataExportPolicyName

#Get the List of ServerProfiles
$ApplianceDataExportPolicyList = Get-IntersightApplianceDataExportPolicy

#Get the list of ApplianceDataExportPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceDataExportPolicyByOrg = Get-IntersightApplianceDataExportPolicy -Organization $org

#Get the ApplianceDataExportPolicy based on query Parameter
$ApplianceDataExportPolicyByQueryParam = Get-IntersightApplianceDataExportPolicy -Filter Name eq ApplianceDataExportPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .