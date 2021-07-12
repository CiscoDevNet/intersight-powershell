#Get the ResourceGroupMember by Name
$ResourceGroupMemberByName = Get-IntersightResourceGroupMember -Name ResourceGroupMemberName

#Get the List of ServerProfiles
$ResourceGroupMemberList = Get-IntersightResourceGroupMember

#Get the list of ResourceGroupMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ResourceGroupMemberByOrg = Get-IntersightResourceGroupMember -Organization $org

#Get the ResourceGroupMember based on query Parameter
$ResourceGroupMemberByQueryParam = Get-IntersightResourceGroupMember -Filter Name eq ResourceGroupMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .