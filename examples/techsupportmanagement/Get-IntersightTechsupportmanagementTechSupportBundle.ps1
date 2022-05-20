#Get the TechsupportmanagementTechSupportBundle by Name
$TechsupportmanagementTechSupportBundleByName = Get-IntersightTechsupportmanagementTechSupportBundle -Name TechsupportmanagementTechSupportBundleName

#Get the List of TechsupportmanagementTechSupportBundle
$TechsupportmanagementTechSupportBundleList = Get-IntersightTechsupportmanagementTechSupportBundle

#Get the list of TechsupportmanagementTechSupportBundle under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$TechsupportmanagementTechSupportBundleByOrg = Get-IntersightTechsupportmanagementTechSupportBundle -Organization $org

#Get the TechsupportmanagementTechSupportBundle based on query Parameter
$TechsupportmanagementTechSupportBundleByQueryParam = Get-IntersightTechsupportmanagementTechSupportBundle -Filter Name eq TechsupportmanagementTechSupportBundleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .