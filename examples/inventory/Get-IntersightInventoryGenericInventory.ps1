#Get the InventoryGenericInventory by Name
$InventoryGenericInventoryByName = Get-IntersightInventoryGenericInventory -Name InventoryGenericInventoryName

#Get the List of ServerProfiles
$InventoryGenericInventoryList = Get-IntersightInventoryGenericInventory

#Get the list of InventoryGenericInventory under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$InventoryGenericInventoryByOrg = Get-IntersightInventoryGenericInventory -Organization $org

#Get the InventoryGenericInventory based on query Parameter
$InventoryGenericInventoryByQueryParam = Get-IntersightInventoryGenericInventory -Filter Name eq InventoryGenericInventoryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .