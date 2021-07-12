#Get the StorageEnclosure by Name
$StorageEnclosureByName = Get-IntersightStorageEnclosure -Name StorageEnclosureName

#Get the List of ServerProfiles
$StorageEnclosureList = Get-IntersightStorageEnclosure

#Get the list of StorageEnclosure under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageEnclosureByOrg = Get-IntersightStorageEnclosure -Organization $org

#Get the StorageEnclosure based on query Parameter
$StorageEnclosureByQueryParam = Get-IntersightStorageEnclosure -Filter Name eq StorageEnclosureName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .