#Get the StorageFlexUtilController by Name
$StorageFlexUtilControllerByName = Get-IntersightStorageFlexUtilController -Name StorageFlexUtilControllerName

#Get the List of ServerProfiles
$StorageFlexUtilControllerList = Get-IntersightStorageFlexUtilController

#Get the list of StorageFlexUtilController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageFlexUtilControllerByOrg = Get-IntersightStorageFlexUtilController -Organization $org

#Get the StorageFlexUtilController based on query Parameter
$StorageFlexUtilControllerByQueryParam = Get-IntersightStorageFlexUtilController -Filter Name eq StorageFlexUtilControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .