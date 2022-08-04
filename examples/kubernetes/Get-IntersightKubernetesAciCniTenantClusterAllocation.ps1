#Get the KubernetesAciCniTenantClusterAllocation by Name
$KubernetesAciCniTenantClusterAllocationByName = Get-IntersightKubernetesAciCniTenantClusterAllocation -Name KubernetesAciCniTenantClusterAllocationName

#Get the List of ServerProfiles
$KubernetesAciCniTenantClusterAllocationList = Get-IntersightKubernetesAciCniTenantClusterAllocation

#Get the list of KubernetesAciCniTenantClusterAllocation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesAciCniTenantClusterAllocationByOrg = Get-IntersightKubernetesAciCniTenantClusterAllocation -Organization $org

#Get the KubernetesAciCniTenantClusterAllocation based on query Parameter
$KubernetesAciCniTenantClusterAllocationByQueryParam = Get-IntersightKubernetesAciCniTenantClusterAllocation -Filter Name eq KubernetesAciCniTenantClusterAllocationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .