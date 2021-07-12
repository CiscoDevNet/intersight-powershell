#Get the HyperflexSysConfigPolicy by Name
$HyperflexSysConfigPolicyByName = Get-IntersightHyperflexSysConfigPolicy -Name HyperflexSysConfigPolicyName

#Get the List of ServerProfiles
$HyperflexSysConfigPolicyList = Get-IntersightHyperflexSysConfigPolicy

#Get the list of HyperflexSysConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexSysConfigPolicyByOrg = Get-IntersightHyperflexSysConfigPolicy -Organization $org

#Get the HyperflexSysConfigPolicy based on query Parameter
$HyperflexSysConfigPolicyByQueryParam = Get-IntersightHyperflexSysConfigPolicy -Filter Name eq HyperflexSysConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .