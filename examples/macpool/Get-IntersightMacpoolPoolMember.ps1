#Get the MacpoolPoolMember by Name
$MacpoolPoolMemberByName = Get-IntersightMacpoolPoolMember -Name MacpoolPoolMemberName

#Get the List of ServerProfiles
$MacpoolPoolMemberList = Get-IntersightMacpoolPoolMember

#Get the list of MacpoolPoolMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MacpoolPoolMemberByOrg = Get-IntersightMacpoolPoolMember -Organization $org

#Get the MacpoolPoolMember based on query Parameter
$MacpoolPoolMemberByQueryParam = Get-IntersightMacpoolPoolMember -Filter Name eq MacpoolPoolMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .