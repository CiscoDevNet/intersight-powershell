#Get the FabricPortOperation by Name
$FabricPortOperationByName = Get-IntersightFabricPortOperation -Name FabricPortOperationName

#Get the List of ServerProfiles
$FabricPortOperationList = Get-IntersightFabricPortOperation

#Get the list of FabricPortOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricPortOperationByOrg = Get-IntersightFabricPortOperation -Organization $org

#Get the FabricPortOperation based on query Parameter
$FabricPortOperationByQueryParam = Get-IntersightFabricPortOperation -Filter Name eq FabricPortOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .