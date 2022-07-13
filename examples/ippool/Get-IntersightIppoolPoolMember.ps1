#Get the IppoolPoolMember by Name
$IppoolPoolMemberByName = Get-IntersightIppoolPoolMember -Name IppoolPoolMemberName

#Get the List of ServerProfiles
$IppoolPoolMemberList = Get-IntersightIppoolPoolMember

#Get the list of IppoolPoolMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IppoolPoolMemberByOrg = Get-IntersightIppoolPoolMember -Organization $org

#Get the IppoolPoolMember based on query Parameter
$IppoolPoolMemberByQueryParam = Get-IntersightIppoolPoolMember -Filter Name eq IppoolPoolMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .