#Get the StorageNetAppCluster by Name
$StorageNetAppClusterByName = Get-IntersightStorageNetAppCluster -Name StorageNetAppClusterName

#Get the List of ServerProfiles
$StorageNetAppClusterList = Get-IntersightStorageNetAppCluster

#Get the list of StorageNetAppCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppClusterByOrg = Get-IntersightStorageNetAppCluster -Organization $org

#Get the StorageNetAppCluster based on query Parameter
$StorageNetAppClusterByQueryParam = Get-IntersightStorageNetAppCluster -Filter Name eq StorageNetAppClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .