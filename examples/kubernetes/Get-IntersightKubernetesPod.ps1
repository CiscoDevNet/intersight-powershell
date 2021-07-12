#Get the KubernetesPod by Name
$KubernetesPodByName = Get-IntersightKubernetesPod -Name KubernetesPodName

#Get the List of ServerProfiles
$KubernetesPodList = Get-IntersightKubernetesPod

#Get the list of KubernetesPod under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesPodByOrg = Get-IntersightKubernetesPod -Organization $org

#Get the KubernetesPod based on query Parameter
$KubernetesPodByQueryParam = Get-IntersightKubernetesPod -Filter Name eq KubernetesPodName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .