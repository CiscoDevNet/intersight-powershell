#Get the HyperflexLocalCredentialPolicy by Name
$HyperflexLocalCredentialPolicyByName = Get-IntersightHyperflexLocalCredentialPolicy -Name HyperflexLocalCredentialPolicyName

#Get the List of ServerProfiles
$HyperflexLocalCredentialPolicyList = Get-IntersightHyperflexLocalCredentialPolicy

#Get the list of HyperflexLocalCredentialPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexLocalCredentialPolicyByOrg = Get-IntersightHyperflexLocalCredentialPolicy -Organization $org

#Get the HyperflexLocalCredentialPolicy based on query Parameter
$HyperflexLocalCredentialPolicyByQueryParam = Get-IntersightHyperflexLocalCredentialPolicy -Filter Name eq HyperflexLocalCredentialPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .