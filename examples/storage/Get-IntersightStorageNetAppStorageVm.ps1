#Get the StorageNetAppStorageVm by Name
$StorageNetAppStorageVmByName = Get-IntersightStorageNetAppStorageVm -Name StorageNetAppStorageVmName

#Get the List of ServerProfiles
$StorageNetAppStorageVmList = Get-IntersightStorageNetAppStorageVm

#Get the list of StorageNetAppStorageVm under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageNetAppStorageVmByOrg = Get-IntersightStorageNetAppStorageVm -Organization $org

#Get the StorageNetAppStorageVm based on query Parameter
$StorageNetAppStorageVmByQueryParam = Get-IntersightStorageNetAppStorageVm -Filter Name eq StorageNetAppStorageVmName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .