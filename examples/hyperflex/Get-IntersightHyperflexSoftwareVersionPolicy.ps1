#Get the HyperflexSoftwareVersionPolicy by Name
$HyperflexSoftwareVersionPolicyByName = Get-IntersightHyperflexSoftwareVersionPolicy -Name HyperflexSoftwareVersionPolicyName

#Get the List of ServerProfiles
$HyperflexSoftwareVersionPolicyList = Get-IntersightHyperflexSoftwareVersionPolicy

#Get the list of HyperflexSoftwareVersionPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexSoftwareVersionPolicyByOrg = Get-IntersightHyperflexSoftwareVersionPolicy -Organization $org

#Get the HyperflexSoftwareVersionPolicy based on query Parameter
$HyperflexSoftwareVersionPolicyByQueryParam = Get-IntersightHyperflexSoftwareVersionPolicy -Filter Name eq HyperflexSoftwareVersionPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .