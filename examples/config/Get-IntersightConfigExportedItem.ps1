#Get the ConfigExportedItem by Name
$ConfigExportedItemByName = Get-IntersightConfigExportedItem -Name ConfigExportedItemName

#Get the List of ServerProfiles
$ConfigExportedItemList = Get-IntersightConfigExportedItem

#Get the list of ConfigExportedItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ConfigExportedItemByOrg = Get-IntersightConfigExportedItem -Organization $org

#Get the ConfigExportedItem based on query Parameter
$ConfigExportedItemByQueryParam = Get-IntersightConfigExportedItem -Filter Name eq ConfigExportedItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .