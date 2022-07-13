#Get the StorageController by Name
$StorageControllerByName = Get-IntersightStorageController -Name StorageControllerName

#Get the List of ServerProfiles
$StorageControllerList = Get-IntersightStorageController

#Get the list of StorageController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageControllerByOrg = Get-IntersightStorageController -Organization $org

#Get the StorageController based on query Parameter
$StorageControllerByQueryParam = Get-IntersightStorageController -Filter Name eq StorageControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .