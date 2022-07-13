#Get the StorageSasPort by Name
$StorageSasPortByName = Get-IntersightStorageSasPort -Name StorageSasPortName

#Get the List of ServerProfiles
$StorageSasPortList = Get-IntersightStorageSasPort

#Get the list of StorageSasPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageSasPortByOrg = Get-IntersightStorageSasPort -Organization $org

#Get the StorageSasPort based on query Parameter
$StorageSasPortByQueryParam = Get-IntersightStorageSasPort -Filter Name eq StorageSasPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .