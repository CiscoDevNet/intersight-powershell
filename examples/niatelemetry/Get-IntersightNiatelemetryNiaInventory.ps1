#Get the NiatelemetryNiaInventory by Name
$NiatelemetryNiaInventoryByName = Get-IntersightNiatelemetryNiaInventory -Name NiatelemetryNiaInventoryName

#Get the List of ServerProfiles
$NiatelemetryNiaInventoryList = Get-IntersightNiatelemetryNiaInventory

#Get the list of NiatelemetryNiaInventory under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryNiaInventoryByOrg = Get-IntersightNiatelemetryNiaInventory -Organization $org

#Get the NiatelemetryNiaInventory based on query Parameter
$NiatelemetryNiaInventoryByQueryParam = Get-IntersightNiatelemetryNiaInventory -Filter Name eq NiatelemetryNiaInventoryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .