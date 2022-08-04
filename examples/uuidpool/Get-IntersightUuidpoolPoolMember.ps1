#Get the UuidpoolPoolMember by Name
$UuidpoolPoolMemberByName = Get-IntersightUuidpoolPoolMember -Name UuidpoolPoolMemberName

#Get the List of ServerProfiles
$UuidpoolPoolMemberList = Get-IntersightUuidpoolPoolMember

#Get the list of UuidpoolPoolMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$UuidpoolPoolMemberByOrg = Get-IntersightUuidpoolPoolMember -Organization $org

#Get the UuidpoolPoolMember based on query Parameter
$UuidpoolPoolMemberByQueryParam = Get-IntersightUuidpoolPoolMember -Filter Name eq UuidpoolPoolMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .