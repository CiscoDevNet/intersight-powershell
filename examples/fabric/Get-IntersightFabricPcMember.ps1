#Get the FabricPcMember by Name
$FabricPcMemberByName = Get-IntersightFabricPcMember -Name FabricPcMemberName

#Get the List of ServerProfiles
$FabricPcMemberList = Get-IntersightFabricPcMember

#Get the list of FabricPcMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricPcMemberByOrg = Get-IntersightFabricPcMember -Organization $org

#Get the FabricPcMember based on query Parameter
$FabricPcMemberByQueryParam = Get-IntersightFabricPcMember -Filter Name eq FabricPcMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .