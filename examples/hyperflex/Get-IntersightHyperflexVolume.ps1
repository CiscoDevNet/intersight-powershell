#Get the HyperflexVolume by Name
$HyperflexVolumeByName = Get-IntersightHyperflexVolume -Name HyperflexVolumeName

#Get the List of ServerProfiles
$HyperflexVolumeList = Get-IntersightHyperflexVolume

#Get the list of HyperflexVolume under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVolumeByOrg = Get-IntersightHyperflexVolume -Organization $org

#Get the HyperflexVolume based on query Parameter
$HyperflexVolumeByQueryParam = Get-IntersightHyperflexVolume -Filter Name eq HyperflexVolumeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .