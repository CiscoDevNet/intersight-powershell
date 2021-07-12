#Get the KubernetesDaemonSet by Name
$KubernetesDaemonSetByName = Get-IntersightKubernetesDaemonSet -Name KubernetesDaemonSetName

#Get the List of ServerProfiles
$KubernetesDaemonSetList = Get-IntersightKubernetesDaemonSet

#Get the list of KubernetesDaemonSet under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesDaemonSetByOrg = Get-IntersightKubernetesDaemonSet -Organization $org

#Get the KubernetesDaemonSet based on query Parameter
$KubernetesDaemonSetByQueryParam = Get-IntersightKubernetesDaemonSet -Filter Name eq KubernetesDaemonSetName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .