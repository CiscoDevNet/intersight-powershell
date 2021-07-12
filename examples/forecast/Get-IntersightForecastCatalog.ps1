#Get the ForecastCatalog by Name
$ForecastCatalogByName = Get-IntersightForecastCatalog -Name ForecastCatalogName

#Get the List of ServerProfiles
$ForecastCatalogList = Get-IntersightForecastCatalog

#Get the list of ForecastCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ForecastCatalogByOrg = Get-IntersightForecastCatalog -Organization $org

#Get the ForecastCatalog based on query Parameter
$ForecastCatalogByQueryParam = Get-IntersightForecastCatalog -Filter Name eq ForecastCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .