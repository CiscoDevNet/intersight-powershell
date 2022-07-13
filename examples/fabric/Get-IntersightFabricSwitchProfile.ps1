#Get the FabricSwitchProfile by Name
$FabricSwitchProfileByName = Get-IntersightFabricSwitchProfile -Name FabricSwitchProfileName

#Get the List of ServerProfiles
$FabricSwitchProfileList = Get-IntersightFabricSwitchProfile

#Get the list of FabricSwitchProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricSwitchProfileByOrg = Get-IntersightFabricSwitchProfile -Organization $org

#Get the FabricSwitchProfile based on query Parameter
$FabricSwitchProfileByQueryParam = Get-IntersightFabricSwitchProfile -Filter Name eq FabricSwitchProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .