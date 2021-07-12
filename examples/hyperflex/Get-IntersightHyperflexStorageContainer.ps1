#Get the HyperflexStorageContainer by Name
$HyperflexStorageContainerByName = Get-IntersightHyperflexStorageContainer -Name HyperflexStorageContainerName

#Get the List of ServerProfiles
$HyperflexStorageContainerList = Get-IntersightHyperflexStorageContainer

#Get the list of HyperflexStorageContainer under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexStorageContainerByOrg = Get-IntersightHyperflexStorageContainer -Organization $org

#Get the HyperflexStorageContainer based on query Parameter
$HyperflexStorageContainerByQueryParam = Get-IntersightHyperflexStorageContainer -Filter Name eq HyperflexStorageContainerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .