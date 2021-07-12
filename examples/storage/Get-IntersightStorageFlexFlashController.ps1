#Get the StorageFlexFlashController by Name
$StorageFlexFlashControllerByName = Get-IntersightStorageFlexFlashController -Name StorageFlexFlashControllerName

#Get the List of ServerProfiles
$StorageFlexFlashControllerList = Get-IntersightStorageFlexFlashController

#Get the list of StorageFlexFlashController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageFlexFlashControllerByOrg = Get-IntersightStorageFlexFlashController -Organization $org

#Get the StorageFlexFlashController based on query Parameter
$StorageFlexFlashControllerByQueryParam = Get-IntersightStorageFlexFlashController -Filter Name eq StorageFlexFlashControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .