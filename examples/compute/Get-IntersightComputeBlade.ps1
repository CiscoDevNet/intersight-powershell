#Get the ComputeBlade by Name
$ComputeBladeByName = Get-IntersightComputeBlade -Name ComputeBladeName

#Get the List of ServerProfiles
$ComputeBladeList = Get-IntersightComputeBlade

#Get the list of ComputeBlade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ComputeBladeByOrg = Get-IntersightComputeBlade -Organization $org

#Get the ComputeBlade based on query Parameter
$ComputeBladeByQueryParam = Get-IntersightComputeBlade -Filter Name eq ComputeBladeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .