#Get the SoftwareHyperflexBundleDistributable by Name
$SoftwareHyperflexBundleDistributableByName = Get-IntersightSoftwareHyperflexBundleDistributable -Name SoftwareHyperflexBundleDistributableName

#Get the List of SoftwareHyperflexBundleDistributable
$SoftwareHyperflexBundleDistributableList = Get-IntersightSoftwareHyperflexBundleDistributable

#Get the list of SoftwareHyperflexBundleDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwareHyperflexBundleDistributableByOrg = Get-IntersightSoftwareHyperflexBundleDistributable -Organization $org

#Get the SoftwareHyperflexBundleDistributable based on query Parameter
$SoftwareHyperflexBundleDistributableByQueryParam = Get-IntersightSoftwareHyperflexBundleDistributable -Filter Name eq SoftwareHyperflexBundleDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .