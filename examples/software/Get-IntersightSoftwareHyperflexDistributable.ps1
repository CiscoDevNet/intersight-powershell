#Get the SoftwareHyperflexDistributable by Name
$SoftwareHyperflexDistributableByName = Get-IntersightSoftwareHyperflexDistributable -Name SoftwareHyperflexDistributableName

#Get the List of SoftwareHyperflexDistributable
$SoftwareHyperflexDistributableList = Get-IntersightSoftwareHyperflexDistributable

#Get the list of SoftwareHyperflexDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwareHyperflexDistributableByOrg = Get-IntersightSoftwareHyperflexDistributable -Organization $org

#Get the SoftwareHyperflexDistributable based on query Parameter
$SoftwareHyperflexDistributableByQueryParam = Get-IntersightSoftwareHyperflexDistributable -Filter Name eq SoftwareHyperflexDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .