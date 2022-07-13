#Get the FabricVlan by Name
$FabricVlanByName = Get-IntersightFabricVlan -Name FabricVlanName

#Get the List of ServerProfiles
$FabricVlanList = Get-IntersightFabricVlan

#Get the list of FabricVlan under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricVlanByOrg = Get-IntersightFabricVlan -Organization $org

#Get the FabricVlan based on query Parameter
$FabricVlanByQueryParam = Get-IntersightFabricVlan -Filter Name eq FabricVlanName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .