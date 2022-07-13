#Get the SdwanRouterPolicy by Name
$SdwanRouterPolicyByName = Get-IntersightSdwanRouterPolicy -Name SdwanRouterPolicyName

#Get the List of ServerProfiles
$SdwanRouterPolicyList = Get-IntersightSdwanRouterPolicy

#Get the list of SdwanRouterPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SdwanRouterPolicyByOrg = Get-IntersightSdwanRouterPolicy -Organization $org

#Get the SdwanRouterPolicy based on query Parameter
$SdwanRouterPolicyByQueryParam = Get-IntersightSdwanRouterPolicy -Filter Name eq SdwanRouterPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .