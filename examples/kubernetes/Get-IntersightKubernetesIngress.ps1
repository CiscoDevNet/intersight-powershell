#Get the KubernetesIngress by Name
$KubernetesIngressByName = Get-IntersightKubernetesIngress -Name KubernetesIngressName

#Get the List of ServerProfiles
$KubernetesIngressList = Get-IntersightKubernetesIngress

#Get the list of KubernetesIngress under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesIngressByOrg = Get-IntersightKubernetesIngress -Organization $org

#Get the KubernetesIngress based on query Parameter
$KubernetesIngressByQueryParam = Get-IntersightKubernetesIngress -Filter Name eq KubernetesIngressName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .