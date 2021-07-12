#Get the FabricPcOperation by Name
$FabricPcOperationByName = Get-IntersightFabricPcOperation -Name FabricPcOperationName

#Get the List of ServerProfiles
$FabricPcOperationList = Get-IntersightFabricPcOperation

#Get the list of FabricPcOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricPcOperationByOrg = Get-IntersightFabricPcOperation -Organization $org

#Get the FabricPcOperation based on query Parameter
$FabricPcOperationByQueryParam = Get-IntersightFabricPcOperation -Filter Name eq FabricPcOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .