#Get the AdapterConfigPolicy by Name
$AdapterConfigPolicyByName = Get-IntersightAdapterConfigPolicy -Name AdapterConfigPolicyName

#Get the List of ServerProfiles
$AdapterConfigPolicyList = Get-IntersightAdapterConfigPolicy

#Get the list of AdapterConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AdapterConfigPolicyByOrg = Get-IntersightAdapterConfigPolicy -Organization $org

#Get the AdapterConfigPolicy based on query Parameter
$AdapterConfigPolicyByQueryParam = Get-IntersightAdapterConfigPolicy -Filter Name eq AdapterConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .