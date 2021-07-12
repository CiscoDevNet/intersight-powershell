#Get the HyperflexHxapVirtualDisk by Name
$HyperflexHxapVirtualDiskByName = Get-IntersightHyperflexHxapVirtualDisk -Name HyperflexHxapVirtualDiskName

#Get the List of ServerProfiles
$HyperflexHxapVirtualDiskList = Get-IntersightHyperflexHxapVirtualDisk

#Get the list of HyperflexHxapVirtualDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHxapVirtualDiskByOrg = Get-IntersightHyperflexHxapVirtualDisk -Organization $org

#Get the HyperflexHxapVirtualDisk based on query Parameter
$HyperflexHxapVirtualDiskByQueryParam = Get-IntersightHyperflexHxapVirtualDisk -Filter Name eq HyperflexHxapVirtualDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .