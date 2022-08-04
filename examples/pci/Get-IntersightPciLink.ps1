#Get the PciLink by Name
$PciLinkByName = Get-IntersightPciLink -Name PciLinkName

#Get the List of ServerProfiles
$PciLinkList = Get-IntersightPciLink

#Get the list of PciLink under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$PciLinkByOrg = Get-IntersightPciLink -Organization $org

#Get the PciLink based on query Parameter
$PciLinkByQueryParam = Get-IntersightPciLink -Filter Name eq PciLinkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .