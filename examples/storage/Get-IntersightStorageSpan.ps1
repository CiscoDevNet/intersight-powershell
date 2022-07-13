#Get the StorageSpan by Name
$StorageSpanByName = Get-IntersightStorageSpan -Name StorageSpanName

#Get the List of ServerProfiles
$StorageSpanList = Get-IntersightStorageSpan

#Get the list of StorageSpan under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageSpanByOrg = Get-IntersightStorageSpan -Organization $org

#Get the StorageSpan based on query Parameter
$StorageSpanByQueryParam = Get-IntersightStorageSpan -Filter Name eq StorageSpanName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .