#Get the StorageNetAppAggregate by Name
$StorageNetAppAggregateByName = Get-IntersightStorageNetAppAggregate -Name StorageNetAppAggregateName

#Get the List of ServerProfiles
$StorageNetAppAggregateList = Get-IntersightStorageNetAppAggregate

#Get the list of StorageNetAppAggregate under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageNetAppAggregateByOrg = Get-IntersightStorageNetAppAggregate -Organization $org

#Get the StorageNetAppAggregate based on query Parameter
$StorageNetAppAggregateByQueryParam = Get-IntersightStorageNetAppAggregate -Filter Name eq StorageNetAppAggregateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .