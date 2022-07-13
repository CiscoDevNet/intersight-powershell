#Get the SnmpPolicy by Name
$SnmpPolicyByName = Get-IntersightSnmpPolicy -Name SnmpPolicyName

#Get the List of SnmpPolicy
$SnmpPolicyList = Get-IntersightSnmpPolicy

#Get the list of SnmpPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SnmpPolicyByOrg = Get-IntersightSnmpPolicy -Organization $org

#Get the SnmpPolicy based on query Parameter
$SnmpPolicyByQueryParam = Get-IntersightSnmpPolicy -Filter Name eq SnmpPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .