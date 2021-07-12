#Get the AccessPolicy by Name
$AccessPolicyByName = Get-IntersightAccessPolicy -Name AccessPolicyName

#Get the List of ServerProfiles
$AccessPolicyList = Get-IntersightAccessPolicy

#Get the list of AccessPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AccessPolicyByOrg = Get-IntersightAccessPolicy -Organization $org

#Get the AccessPolicy based on query Parameter
$AccessPolicyByQueryParam = Get-IntersightAccessPolicy -Filter Name eq AccessPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .