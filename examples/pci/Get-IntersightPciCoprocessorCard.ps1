#Get the PciCoprocessorCard by Name
$PciCoprocessorCardByName = Get-IntersightPciCoprocessorCard -Name PciCoprocessorCardName

#Get the List of ServerProfiles
$PciCoprocessorCardList = Get-IntersightPciCoprocessorCard

#Get the list of PciCoprocessorCard under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$PciCoprocessorCardByOrg = Get-IntersightPciCoprocessorCard -Organization $org

#Get the PciCoprocessorCard based on query Parameter
$PciCoprocessorCardByQueryParam = Get-IntersightPciCoprocessorCard -Filter Name eq PciCoprocessorCardName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .