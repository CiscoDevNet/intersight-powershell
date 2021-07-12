#Get the SoftwarerepositoryCatalog by Name
$SoftwarerepositoryCatalogByName = Get-IntersightSoftwarerepositoryCatalog -Name SoftwarerepositoryCatalogName

#Get the List of ServerProfiles
$SoftwarerepositoryCatalogList = Get-IntersightSoftwarerepositoryCatalog

#Get the list of SoftwarerepositoryCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryCatalogByOrg = Get-IntersightSoftwarerepositoryCatalog -Organization $org

#Get the SoftwarerepositoryCatalog based on query Parameter
$SoftwarerepositoryCatalogByQueryParam = Get-IntersightSoftwarerepositoryCatalog -Filter Name eq SoftwarerepositoryCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .