#Get the HyperflexAppCatalog by Name
$HyperflexAppCatalogByName = Get-IntersightHyperflexAppCatalog -Name HyperflexAppCatalogName

#Get the List of ServerProfiles
$HyperflexAppCatalogList = Get-IntersightHyperflexAppCatalog

#Get the list of HyperflexAppCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexAppCatalogByOrg = Get-IntersightHyperflexAppCatalog -Organization $org

#Get the HyperflexAppCatalog based on query Parameter
$HyperflexAppCatalogByQueryParam = Get-IntersightHyperflexAppCatalog -Filter Name eq HyperflexAppCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .