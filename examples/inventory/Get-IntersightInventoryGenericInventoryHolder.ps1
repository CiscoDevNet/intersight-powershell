#Get the InventoryGenericInventoryHolder by Name
$InventoryGenericInventoryHolderByName = Get-IntersightInventoryGenericInventoryHolder -Name InventoryGenericInventoryHolderName

#Get the List of ServerProfiles
$InventoryGenericInventoryHolderList = Get-IntersightInventoryGenericInventoryHolder

#Get the list of InventoryGenericInventoryHolder under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$InventoryGenericInventoryHolderByOrg = Get-IntersightInventoryGenericInventoryHolder -Organization $org

#Get the InventoryGenericInventoryHolder based on query Parameter
$InventoryGenericInventoryHolderByQueryParam = Get-IntersightInventoryGenericInventoryHolder -Filter Name eq InventoryGenericInventoryHolderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .