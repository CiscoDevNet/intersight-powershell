#Get the IamEndPointUserPolicy by Name
$IamEndPointUserPolicyByName = Get-IntersightIamEndPointUserPolicy -Name IamEndPointUserPolicyName

#Get the List of ServerProfiles
$IamEndPointUserPolicyList = Get-IntersightIamEndPointUserPolicy

#Get the list of IamEndPointUserPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamEndPointUserPolicyByOrg = Get-IntersightIamEndPointUserPolicy -Organization $org

#Get the IamEndPointUserPolicy based on query Parameter
$IamEndPointUserPolicyByQueryParam = Get-IntersightIamEndPointUserPolicy -Filter Name eq IamEndPointUserPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .