#Get the NiatelemetryNiaInventoryFabric by Name
$NiatelemetryNiaInventoryFabricByName = Get-IntersightNiatelemetryNiaInventoryFabric -Name NiatelemetryNiaInventoryFabricName

#Get the List of ServerProfiles
$NiatelemetryNiaInventoryFabricList = Get-IntersightNiatelemetryNiaInventoryFabric

#Get the list of NiatelemetryNiaInventoryFabric under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNiaInventoryFabricByOrg = Get-IntersightNiatelemetryNiaInventoryFabric -Organization $org

#Get the NiatelemetryNiaInventoryFabric based on query Parameter
$NiatelemetryNiaInventoryFabricByQueryParam = Get-IntersightNiatelemetryNiaInventoryFabric -Filter Name eq NiatelemetryNiaInventoryFabricName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .