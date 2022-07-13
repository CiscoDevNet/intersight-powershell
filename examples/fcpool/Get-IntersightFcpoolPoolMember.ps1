#Get the FcpoolPoolMember by Name
$FcpoolPoolMemberByName = Get-IntersightFcpoolPoolMember -Name FcpoolPoolMemberName

#Get the List of ServerProfiles
$FcpoolPoolMemberList = Get-IntersightFcpoolPoolMember

#Get the list of FcpoolPoolMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FcpoolPoolMemberByOrg = Get-IntersightFcpoolPoolMember -Organization $org

#Get the FcpoolPoolMember based on query Parameter
$FcpoolPoolMemberByQueryParam = Get-IntersightFcpoolPoolMember -Filter Name eq FcpoolPoolMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .