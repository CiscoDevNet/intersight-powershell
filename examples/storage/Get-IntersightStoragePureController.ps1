#Get the StoragePureController by Name
$StoragePureControllerByName = Get-IntersightStoragePureController -Name StoragePureControllerName

#Get the List of ServerProfiles
$StoragePureControllerList = Get-IntersightStoragePureController

#Get the list of StoragePureController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureControllerByOrg = Get-IntersightStoragePureController -Organization $org

#Get the StoragePureController based on query Parameter
$StoragePureControllerByQueryParam = Get-IntersightStoragePureController -Filter Name eq StoragePureControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .