#Get the IpmioverlanPolicy by Name
$IpmioverlanPolicyByName = Get-IntersightIpmioverlanPolicy -Name IpmioverlanPolicyName

#Get the List of ServerProfiles
$IpmioverlanPolicyList = Get-IntersightIpmioverlanPolicy

#Get the list of IpmioverlanPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IpmioverlanPolicyByOrg = Get-IntersightIpmioverlanPolicy -Organization $org

#Get the IpmioverlanPolicy based on query Parameter
$IpmioverlanPolicyByQueryParam = Get-IntersightIpmioverlanPolicy -Filter Name eq IpmioverlanPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .