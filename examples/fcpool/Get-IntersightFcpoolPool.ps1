#Get the FcpoolPool by Name
$FcpoolPoolByName = Get-IntersightFcpoolPool -Name FcpoolPoolName

#Get the List of ServerProfiles
$FcpoolPoolList = Get-IntersightFcpoolPool

#Get the list of FcpoolPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FcpoolPoolByOrg = Get-IntersightFcpoolPool -Organization $org

#Get the FcpoolPool based on query Parameter
$FcpoolPoolByQueryParam = Get-IntersightFcpoolPool -Filter Name eq FcpoolPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .