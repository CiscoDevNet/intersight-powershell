#Get the ApplianceImageBundle by Name
$ApplianceImageBundleByName = Get-IntersightApplianceImageBundle -Name ApplianceImageBundleName

#Get the List of ServerProfiles
$ApplianceImageBundleList = Get-IntersightApplianceImageBundle

#Get the list of ApplianceImageBundle under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceImageBundleByOrg = Get-IntersightApplianceImageBundle -Organization $org

#Get the ApplianceImageBundle based on query Parameter
$ApplianceImageBundleByQueryParam = Get-IntersightApplianceImageBundle -Filter Name eq ApplianceImageBundleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .