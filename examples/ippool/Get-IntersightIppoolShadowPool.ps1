#Get the IppoolShadowPool by Name
$IppoolShadowPoolByName = Get-IntersightIppoolShadowPool -Name IppoolShadowPoolName

#Get the List of ServerProfiles
$IppoolShadowPoolList = Get-IntersightIppoolShadowPool

#Get the list of IppoolShadowPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IppoolShadowPoolByOrg = Get-IntersightIppoolShadowPool -Organization $org

#Get the IppoolShadowPool based on query Parameter
$IppoolShadowPoolByQueryParam = Get-IntersightIppoolShadowPool -Filter Name eq IppoolShadowPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .