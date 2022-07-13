#Get the MacpoolPool by Name
$MacpoolPoolByName = Get-IntersightMacpoolPool -Name MacpoolPoolName

#Get the List of ServerProfiles
$MacpoolPoolList = Get-IntersightMacpoolPool

#Get the list of MacpoolPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MacpoolPoolByOrg = Get-IntersightMacpoolPool -Organization $org

#Get the MacpoolPool based on query Parameter
$MacpoolPoolByQueryParam = Get-IntersightMacpoolPool -Filter Name eq MacpoolPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .