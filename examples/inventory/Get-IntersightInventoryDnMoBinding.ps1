#Get the InventoryDnMoBinding by Name
$InventoryDnMoBindingByName = Get-IntersightInventoryDnMoBinding -Name InventoryDnMoBindingName

#Get the List of ServerProfiles
$InventoryDnMoBindingList = Get-IntersightInventoryDnMoBinding

#Get the list of InventoryDnMoBinding under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$InventoryDnMoBindingByOrg = Get-IntersightInventoryDnMoBinding -Organization $org

#Get the InventoryDnMoBinding based on query Parameter
$InventoryDnMoBindingByQueryParam = Get-IntersightInventoryDnMoBinding -Filter Name eq InventoryDnMoBindingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .