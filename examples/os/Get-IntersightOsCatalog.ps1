#Get the OsCatalog by Name
$OsCatalogByName = Get-IntersightOsCatalog -Name OsCatalogName

#Get the List of ServerProfiles
$OsCatalogList = Get-IntersightOsCatalog

#Get the list of OsCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OsCatalogByOrg = Get-IntersightOsCatalog -Organization $org

#Get the OsCatalog based on query Parameter
$OsCatalogByQueryParam = Get-IntersightOsCatalog -Filter Name eq OsCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .