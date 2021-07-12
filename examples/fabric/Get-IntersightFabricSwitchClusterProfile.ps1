#Get the FabricSwitchClusterProfile by Name
$FabricSwitchClusterProfileByName = Get-IntersightFabricSwitchClusterProfile -Name FabricSwitchClusterProfileName

#Get the List of ServerProfiles
$FabricSwitchClusterProfileList = Get-IntersightFabricSwitchClusterProfile

#Get the list of FabricSwitchClusterProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricSwitchClusterProfileByOrg = Get-IntersightFabricSwitchClusterProfile -Organization $org

#Get the FabricSwitchClusterProfile based on query Parameter
$FabricSwitchClusterProfileByQueryParam = Get-IntersightFabricSwitchClusterProfile -Filter Name eq FabricSwitchClusterProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .