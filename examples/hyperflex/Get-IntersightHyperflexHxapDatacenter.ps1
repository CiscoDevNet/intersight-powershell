#Get the HyperflexHxapDatacenter by Name
$HyperflexHxapDatacenterByName = Get-IntersightHyperflexHxapDatacenter -Name HyperflexHxapDatacenterName

#Get the List of ServerProfiles
$HyperflexHxapDatacenterList = Get-IntersightHyperflexHxapDatacenter

#Get the list of HyperflexHxapDatacenter under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapDatacenterByOrg = Get-IntersightHyperflexHxapDatacenter -Organization $org

#Get the HyperflexHxapDatacenter based on query Parameter
$HyperflexHxapDatacenterByQueryParam = Get-IntersightHyperflexHxapDatacenter -Filter Name eq HyperflexHxapDatacenterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .