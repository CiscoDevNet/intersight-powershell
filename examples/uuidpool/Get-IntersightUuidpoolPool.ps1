#Get the UuidpoolPool by Name
$UuidpoolPoolByName = Get-IntersightUuidpoolPool -Name UuidpoolPoolName

#Get the List of UuidpoolPool
$UuidpoolPoolList = Get-IntersightUuidpoolPool

#Get the list of UuidpoolPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$UuidpoolPoolByOrg = Get-IntersightUuidpoolPool -Organization $org

#Get the UuidpoolPool based on query Parameter
$UuidpoolPoolByQueryParam = Get-IntersightUuidpoolPool -Filter Name eq UuidpoolPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .