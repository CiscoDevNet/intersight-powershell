#Get the PciDevice by Name
$PciDeviceByName = Get-IntersightPciDevice -Name PciDeviceName

#Get the List of ServerProfiles
$PciDeviceList = Get-IntersightPciDevice

#Get the list of PciDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$PciDeviceByOrg = Get-IntersightPciDevice -Organization $org

#Get the PciDevice based on query Parameter
$PciDeviceByQueryParam = Get-IntersightPciDevice -Filter Name eq PciDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .