#Get the SdcardPolicy by Name
$SdcardPolicyByName = Get-IntersightSdcardPolicy -Name SdcardPolicyName

#Get the List of ServerProfiles
$SdcardPolicyList = Get-IntersightSdcardPolicy

#Get the list of SdcardPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SdcardPolicyByOrg = Get-IntersightSdcardPolicy -Organization $org

#Get the SdcardPolicy based on query Parameter
$SdcardPolicyByQueryParam = Get-IntersightSdcardPolicy -Filter Name eq SdcardPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .