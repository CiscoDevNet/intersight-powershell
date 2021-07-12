#Get the NiatelemetryFabricModuleDetails by Name
$NiatelemetryFabricModuleDetailsByName = Get-IntersightNiatelemetryFabricModuleDetails -Name NiatelemetryFabricModuleDetailsName

#Get the List of ServerProfiles
$NiatelemetryFabricModuleDetailsList = Get-IntersightNiatelemetryFabricModuleDetails

#Get the list of NiatelemetryFabricModuleDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryFabricModuleDetailsByOrg = Get-IntersightNiatelemetryFabricModuleDetails -Organization $org

#Get the NiatelemetryFabricModuleDetails based on query Parameter
$NiatelemetryFabricModuleDetailsByQueryParam = Get-IntersightNiatelemetryFabricModuleDetails -Filter Name eq NiatelemetryFabricModuleDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .