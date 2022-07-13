#Get the HyperflexHxapDvswitch by Name
$HyperflexHxapDvswitchByName = Get-IntersightHyperflexHxapDvswitch -Name HyperflexHxapDvswitchName

#Get the List of ServerProfiles
$HyperflexHxapDvswitchList = Get-IntersightHyperflexHxapDvswitch

#Get the list of HyperflexHxapDvswitch under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapDvswitchByOrg = Get-IntersightHyperflexHxapDvswitch -Organization $org

#Get the HyperflexHxapDvswitch based on query Parameter
$HyperflexHxapDvswitchByQueryParam = Get-IntersightHyperflexHxapDvswitch -Filter Name eq HyperflexHxapDvswitchName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .