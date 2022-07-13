#Get the MacpoolIdBlock by Name
$MacpoolIdBlockByName = Get-IntersightMacpoolIdBlock -Name MacpoolIdBlockName

#Get the List of ServerProfiles
$MacpoolIdBlockList = Get-IntersightMacpoolIdBlock

#Get the list of MacpoolIdBlock under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MacpoolIdBlockByOrg = Get-IntersightMacpoolIdBlock -Organization $org

#Get the MacpoolIdBlock based on query Parameter
$MacpoolIdBlockByQueryParam = Get-IntersightMacpoolIdBlock -Filter Name eq MacpoolIdBlockName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .