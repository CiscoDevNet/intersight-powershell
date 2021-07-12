#Get the FabricConfigResult by Name
$FabricConfigResultByName = Get-IntersightFabricConfigResult -Name FabricConfigResultName

#Get the List of ServerProfiles
$FabricConfigResultList = Get-IntersightFabricConfigResult

#Get the list of FabricConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricConfigResultByOrg = Get-IntersightFabricConfigResult -Organization $org

#Get the FabricConfigResult based on query Parameter
$FabricConfigResultByQueryParam = Get-IntersightFabricConfigResult -Filter Name eq FabricConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .