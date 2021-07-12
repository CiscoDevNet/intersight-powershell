#Get the HyperflexSoftwareDistributionVersion by Name
$HyperflexSoftwareDistributionVersionByName = Get-IntersightHyperflexSoftwareDistributionVersion -Name HyperflexSoftwareDistributionVersionName

#Get the List of ServerProfiles
$HyperflexSoftwareDistributionVersionList = Get-IntersightHyperflexSoftwareDistributionVersion

#Get the list of HyperflexSoftwareDistributionVersion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexSoftwareDistributionVersionByOrg = Get-IntersightHyperflexSoftwareDistributionVersion -Organization $org

#Get the HyperflexSoftwareDistributionVersion based on query Parameter
$HyperflexSoftwareDistributionVersionByQueryParam = Get-IntersightHyperflexSoftwareDistributionVersion -Filter Name eq HyperflexSoftwareDistributionVersionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .