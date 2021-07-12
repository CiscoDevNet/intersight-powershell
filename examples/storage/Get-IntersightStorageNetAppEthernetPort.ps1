#Get the StorageNetAppEthernetPort by Name
$StorageNetAppEthernetPortByName = Get-IntersightStorageNetAppEthernetPort -Name StorageNetAppEthernetPortName

#Get the List of ServerProfiles
$StorageNetAppEthernetPortList = Get-IntersightStorageNetAppEthernetPort

#Get the list of StorageNetAppEthernetPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppEthernetPortByOrg = Get-IntersightStorageNetAppEthernetPort -Organization $org

#Get the StorageNetAppEthernetPort based on query Parameter
$StorageNetAppEthernetPortByQueryParam = Get-IntersightStorageNetAppEthernetPort -Filter Name eq StorageNetAppEthernetPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .