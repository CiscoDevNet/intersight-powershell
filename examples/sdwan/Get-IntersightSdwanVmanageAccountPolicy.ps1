#Get the SdwanVmanageAccountPolicy by Name
$SdwanVmanageAccountPolicyByName = Get-IntersightSdwanVmanageAccountPolicy -Name SdwanVmanageAccountPolicyName

#Get the List of ServerProfiles
$SdwanVmanageAccountPolicyList = Get-IntersightSdwanVmanageAccountPolicy

#Get the list of SdwanVmanageAccountPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SdwanVmanageAccountPolicyByOrg = Get-IntersightSdwanVmanageAccountPolicy -Organization $org

#Get the SdwanVmanageAccountPolicy based on query Parameter
$SdwanVmanageAccountPolicyByQueryParam = Get-IntersightSdwanVmanageAccountPolicy -Filter Name eq SdwanVmanageAccountPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .