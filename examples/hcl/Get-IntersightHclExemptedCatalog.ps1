#Get the HclExemptedCatalog by Name
$HclExemptedCatalogByName = Get-IntersightHclExemptedCatalog -Name HclExemptedCatalogName

#Get the List of ServerProfiles
$HclExemptedCatalogList = Get-IntersightHclExemptedCatalog

#Get the list of HclExemptedCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HclExemptedCatalogByOrg = Get-IntersightHclExemptedCatalog -Organization $org

#Get the HclExemptedCatalog based on query Parameter
$HclExemptedCatalogByQueryParam = Get-IntersightHclExemptedCatalog -Filter Name eq HclExemptedCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .