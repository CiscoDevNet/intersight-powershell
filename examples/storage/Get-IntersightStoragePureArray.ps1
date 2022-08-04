#Get the StoragePureArray by Name
$StoragePureArrayByName = Get-IntersightStoragePureArray -Name StoragePureArrayName

#Get the List of ServerProfiles
$StoragePureArrayList = Get-IntersightStoragePureArray

#Get the list of StoragePureArray under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureArrayByOrg = Get-IntersightStoragePureArray -Organization $org

#Get the StoragePureArray based on query Parameter
$StoragePureArrayByQueryParam = Get-IntersightStoragePureArray -Filter Name eq StoragePureArrayName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .