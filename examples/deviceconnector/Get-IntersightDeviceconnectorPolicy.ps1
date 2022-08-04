#Get the DeviceconnectorPolicy by Name
$DeviceconnectorPolicyByName = Get-IntersightDeviceconnectorPolicy -Name DeviceconnectorPolicyName

#Get the List of ServerProfiles
$DeviceconnectorPolicyList = Get-IntersightDeviceconnectorPolicy

#Get the list of DeviceconnectorPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$DeviceconnectorPolicyByOrg = Get-IntersightDeviceconnectorPolicy -Organization $org

#Get the DeviceconnectorPolicy based on query Parameter
$DeviceconnectorPolicyByQueryParam = Get-IntersightDeviceconnectorPolicy -Filter Name eq DeviceconnectorPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .