#Get the KubernetesNode by Name
$KubernetesNodeByName = Get-IntersightKubernetesNode -Name KubernetesNodeName

#Get the List of ServerProfiles
$KubernetesNodeList = Get-IntersightKubernetesNode

#Get the list of KubernetesNode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesNodeByOrg = Get-IntersightKubernetesNode -Organization $org

#Get the KubernetesNode based on query Parameter
$KubernetesNodeByQueryParam = Get-IntersightKubernetesNode -Filter Name eq KubernetesNodeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .