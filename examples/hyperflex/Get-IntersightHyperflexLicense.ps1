#Get the HyperflexLicense by Name
$HyperflexLicenseByName = Get-IntersightHyperflexLicense -Name HyperflexLicenseName

#Get the List of ServerProfiles
$HyperflexLicenseList = Get-IntersightHyperflexLicense

#Get the list of HyperflexLicense under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexLicenseByOrg = Get-IntersightHyperflexLicense -Organization $org

#Get the HyperflexLicense based on query Parameter
$HyperflexLicenseByQueryParam = Get-IntersightHyperflexLicense -Filter Name eq HyperflexLicenseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .