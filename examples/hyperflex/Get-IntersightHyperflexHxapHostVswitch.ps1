#Get the HyperflexHxapHostVswitch by Name
$HyperflexHxapHostVswitchByName = Get-IntersightHyperflexHxapHostVswitch -Name HyperflexHxapHostVswitchName

#Get the List of ServerProfiles
$HyperflexHxapHostVswitchList = Get-IntersightHyperflexHxapHostVswitch

#Get the list of HyperflexHxapHostVswitch under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHxapHostVswitchByOrg = Get-IntersightHyperflexHxapHostVswitch -Organization $org

#Get the HyperflexHxapHostVswitch based on query Parameter
$HyperflexHxapHostVswitchByQueryParam = Get-IntersightHyperflexHxapHostVswitch -Filter Name eq HyperflexHxapHostVswitchName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .