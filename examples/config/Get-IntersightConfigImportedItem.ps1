#Get the ConfigImportedItem by Name
$ConfigImportedItemByName = Get-IntersightConfigImportedItem -Name ConfigImportedItemName

#Get the List of ServerProfiles
$ConfigImportedItemList = Get-IntersightConfigImportedItem

#Get the list of ConfigImportedItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ConfigImportedItemByOrg = Get-IntersightConfigImportedItem -Organization $org

#Get the ConfigImportedItem based on query Parameter
$ConfigImportedItemByQueryParam = Get-IntersightConfigImportedItem -Filter Name eq ConfigImportedItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .