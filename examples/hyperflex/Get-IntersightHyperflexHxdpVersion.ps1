#Get the HyperflexHxdpVersion by Name
$HyperflexHxdpVersionByName = Get-IntersightHyperflexHxdpVersion -Name HyperflexHxdpVersionName

#Get the List of ServerProfiles
$HyperflexHxdpVersionList = Get-IntersightHyperflexHxdpVersion

#Get the list of HyperflexHxdpVersion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxdpVersionByOrg = Get-IntersightHyperflexHxdpVersion -Organization $org

#Get the HyperflexHxdpVersion based on query Parameter
$HyperflexHxdpVersionByQueryParam = Get-IntersightHyperflexHxdpVersion -Filter Name eq HyperflexHxdpVersionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .