#Get the IqnpoolPoolMember by Name
$IqnpoolPoolMemberByName = Get-IntersightIqnpoolPoolMember -Name IqnpoolPoolMemberName

#Get the List of ServerProfiles
$IqnpoolPoolMemberList = Get-IntersightIqnpoolPoolMember

#Get the list of IqnpoolPoolMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IqnpoolPoolMemberByOrg = Get-IntersightIqnpoolPoolMember -Organization $org

#Get the IqnpoolPoolMember based on query Parameter
$IqnpoolPoolMemberByQueryParam = Get-IntersightIqnpoolPoolMember -Filter Name eq IqnpoolPoolMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .