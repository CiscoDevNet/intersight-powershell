#Get the StorageNetAppLun by Name
$StorageNetAppLunByName = Get-IntersightStorageNetAppLun -Name StorageNetAppLunName

#Get the List of ServerProfiles
$StorageNetAppLunList = Get-IntersightStorageNetAppLun

#Get the list of StorageNetAppLun under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageNetAppLunByOrg = Get-IntersightStorageNetAppLun -Organization $org

#Get the StorageNetAppLun based on query Parameter
$StorageNetAppLunByQueryParam = Get-IntersightStorageNetAppLun -Filter Name eq StorageNetAppLunName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .