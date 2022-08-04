#Get the UuidpoolBlock by Name
$UuidpoolBlockByName = Get-IntersightUuidpoolBlock -Name UuidpoolBlockName

#Get the List of ServerProfiles
$UuidpoolBlockList = Get-IntersightUuidpoolBlock

#Get the list of UuidpoolBlock under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$UuidpoolBlockByOrg = Get-IntersightUuidpoolBlock -Organization $org

#Get the UuidpoolBlock based on query Parameter
$UuidpoolBlockByQueryParam = Get-IntersightUuidpoolBlock -Filter Name eq UuidpoolBlockName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .