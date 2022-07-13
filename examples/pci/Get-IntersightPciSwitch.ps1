#Get the PciSwitch by Name
$PciSwitchByName = Get-IntersightPciSwitch -Name PciSwitchName

#Get the List of ServerProfiles
$PciSwitchList = Get-IntersightPciSwitch

#Get the list of PciSwitch under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$PciSwitchByOrg = Get-IntersightPciSwitch -Organization $org

#Get the PciSwitch based on query Parameter
$PciSwitchByQueryParam = Get-IntersightPciSwitch -Filter Name eq PciSwitchName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .