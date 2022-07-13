#Get the IppoolShadowBlock by Name
$IppoolShadowBlockByName = Get-IntersightIppoolShadowBlock -Name IppoolShadowBlockName

#Get the List of ServerProfiles
$IppoolShadowBlockList = Get-IntersightIppoolShadowBlock

#Get the list of IppoolShadowBlock under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IppoolShadowBlockByOrg = Get-IntersightIppoolShadowBlock -Organization $org

#Get the IppoolShadowBlock based on query Parameter
$IppoolShadowBlockByQueryParam = Get-IntersightIppoolShadowBlock -Filter Name eq IppoolShadowBlockName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .