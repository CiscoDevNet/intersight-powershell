#Get the FabricPortMode by Name
$FabricPortModeByName = Get-IntersightFabricPortMode -Name FabricPortModeName

#Get the List of ServerProfiles
$FabricPortModeList = Get-IntersightFabricPortMode

#Get the list of FabricPortMode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricPortModeByOrg = Get-IntersightFabricPortMode -Organization $org

#Get the FabricPortMode based on query Parameter
$FabricPortModeByQueryParam = Get-IntersightFabricPortMode -Filter Name eq FabricPortModeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .