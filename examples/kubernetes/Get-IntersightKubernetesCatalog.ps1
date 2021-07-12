#Get the KubernetesCatalog by Name
$KubernetesCatalogByName = Get-IntersightKubernetesCatalog -Name KubernetesCatalogName

#Get the List of ServerProfiles
$KubernetesCatalogList = Get-IntersightKubernetesCatalog

#Get the list of KubernetesCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesCatalogByOrg = Get-IntersightKubernetesCatalog -Organization $org

#Get the KubernetesCatalog based on query Parameter
$KubernetesCatalogByQueryParam = Get-IntersightKubernetesCatalog -Filter Name eq KubernetesCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .