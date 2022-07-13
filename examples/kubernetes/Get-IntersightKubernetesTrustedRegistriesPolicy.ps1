#Get the KubernetesTrustedRegistriesPolicy by Name
$KubernetesTrustedRegistriesPolicyByName = Get-IntersightKubernetesTrustedRegistriesPolicy -Name KubernetesTrustedRegistriesPolicyName

#Get the List of ServerProfiles
$KubernetesTrustedRegistriesPolicyList = Get-IntersightKubernetesTrustedRegistriesPolicy

#Get the list of KubernetesTrustedRegistriesPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesTrustedRegistriesPolicyByOrg = Get-IntersightKubernetesTrustedRegistriesPolicy -Organization $org

#Get the KubernetesTrustedRegistriesPolicy based on query Parameter
$KubernetesTrustedRegistriesPolicyByQueryParam = Get-IntersightKubernetesTrustedRegistriesPolicy -Filter Name eq KubernetesTrustedRegistriesPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .