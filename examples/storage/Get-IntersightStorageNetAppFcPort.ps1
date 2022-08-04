#Get the StorageNetAppFcPort by Name
$StorageNetAppFcPortByName = Get-IntersightStorageNetAppFcPort -Name StorageNetAppFcPortName

#Get the List of ServerProfiles
$StorageNetAppFcPortList = Get-IntersightStorageNetAppFcPort

#Get the list of StorageNetAppFcPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageNetAppFcPortByOrg = Get-IntersightStorageNetAppFcPort -Organization $org

#Get the StorageNetAppFcPort based on query Parameter
$StorageNetAppFcPortByQueryParam = Get-IntersightStorageNetAppFcPort -Filter Name eq StorageNetAppFcPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .