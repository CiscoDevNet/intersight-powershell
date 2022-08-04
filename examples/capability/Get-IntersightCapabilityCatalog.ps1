#Get the CapabilityCatalog by Name
$CapabilityCatalogByName = Get-IntersightCapabilityCatalog -Name CapabilityCatalogName

#Get the List of ServerProfiles
$CapabilityCatalogList = Get-IntersightCapabilityCatalog

#Get the list of CapabilityCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityCatalogByOrg = Get-IntersightCapabilityCatalog -Organization $org

#Get the CapabilityCatalog based on query Parameter
$CapabilityCatalogByQueryParam = Get-IntersightCapabilityCatalog -Filter Name eq CapabilityCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .