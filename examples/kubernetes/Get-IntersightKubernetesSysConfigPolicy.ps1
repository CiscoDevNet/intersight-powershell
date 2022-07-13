#Get the KubernetesSysConfigPolicy by Name
$KubernetesSysConfigPolicyByName = Get-IntersightKubernetesSysConfigPolicy -Name KubernetesSysConfigPolicyName

#Get the List of ServerProfiles
$KubernetesSysConfigPolicyList = Get-IntersightKubernetesSysConfigPolicy

#Get the list of KubernetesSysConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesSysConfigPolicyByOrg = Get-IntersightKubernetesSysConfigPolicy -Organization $org

#Get the KubernetesSysConfigPolicy based on query Parameter
$KubernetesSysConfigPolicyByQueryParam = Get-IntersightKubernetesSysConfigPolicy -Filter Name eq KubernetesSysConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .