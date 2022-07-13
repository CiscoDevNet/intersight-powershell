#Get the StoragePureHost by Name
$StoragePureHostByName = Get-IntersightStoragePureHost -Name StoragePureHostName

#Get the List of ServerProfiles
$StoragePureHostList = Get-IntersightStoragePureHost

#Get the list of StoragePureHost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureHostByOrg = Get-IntersightStoragePureHost -Organization $org

#Get the StoragePureHost based on query Parameter
$StoragePureHostByQueryParam = Get-IntersightStoragePureHost -Filter Name eq StoragePureHostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .