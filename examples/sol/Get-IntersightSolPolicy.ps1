#Get the SolPolicy by Name
$SolPolicyByName = Get-IntersightSolPolicy -Name SolPolicyName

#Get the List of SolPolicy
$SolPolicyList = Get-IntersightSolPolicy

#Get the list of SolPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SolPolicyByOrg = Get-IntersightSolPolicy -Organization $org

#Get the SolPolicy based on query Parameter
$SolPolicyByQueryParam = Get-IntersightSolPolicy -Filter Name eq SolPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .