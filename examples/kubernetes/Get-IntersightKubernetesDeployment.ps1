#Get the KubernetesDeployment by Name
$KubernetesDeploymentByName = Get-IntersightKubernetesDeployment -Name KubernetesDeploymentName

#Get the List of ServerProfiles
$KubernetesDeploymentList = Get-IntersightKubernetesDeployment

#Get the list of KubernetesDeployment under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesDeploymentByOrg = Get-IntersightKubernetesDeployment -Organization $org

#Get the KubernetesDeployment based on query Parameter
$KubernetesDeploymentByQueryParam = Get-IntersightKubernetesDeployment -Filter Name eq KubernetesDeploymentName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .