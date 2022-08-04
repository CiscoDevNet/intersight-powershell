#Get the StoragePureHostLun by Name
$StoragePureHostLunByName = Get-IntersightStoragePureHostLun -Name StoragePureHostLunName

#Get the List of ServerProfiles
$StoragePureHostLunList = Get-IntersightStoragePureHostLun

#Get the list of StoragePureHostLun under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureHostLunByOrg = Get-IntersightStoragePureHostLun -Organization $org

#Get the StoragePureHostLun based on query Parameter
$StoragePureHostLunByQueryParam = Get-IntersightStoragePureHostLun -Filter Name eq StoragePureHostLunName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .