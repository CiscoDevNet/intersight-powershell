#Get the StorageNetAppNode by Name
$StorageNetAppNodeByName = Get-IntersightStorageNetAppNode -Name StorageNetAppNodeName

#Get the List of ServerProfiles
$StorageNetAppNodeList = Get-IntersightStorageNetAppNode

#Get the list of StorageNetAppNode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageNetAppNodeByOrg = Get-IntersightStorageNetAppNode -Organization $org

#Get the StorageNetAppNode based on query Parameter
$StorageNetAppNodeByQueryParam = Get-IntersightStorageNetAppNode -Filter Name eq StorageNetAppNodeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .