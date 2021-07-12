#Get the KubernetesAddonDefinition by Name
$KubernetesAddonDefinitionByName = Get-IntersightKubernetesAddonDefinition -Name KubernetesAddonDefinitionName

#Get the List of ServerProfiles
$KubernetesAddonDefinitionList = Get-IntersightKubernetesAddonDefinition

#Get the list of KubernetesAddonDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesAddonDefinitionByOrg = Get-IntersightKubernetesAddonDefinition -Organization $org

#Get the KubernetesAddonDefinition based on query Parameter
$KubernetesAddonDefinitionByQueryParam = Get-IntersightKubernetesAddonDefinition -Filter Name eq KubernetesAddonDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .