#Get the HyperflexServerFirmwareVersionEntry by Name
$HyperflexServerFirmwareVersionEntryByName = Get-IntersightHyperflexServerFirmwareVersionEntry -Name HyperflexServerFirmwareVersionEntryName

#Get the List of ServerProfiles
$HyperflexServerFirmwareVersionEntryList = Get-IntersightHyperflexServerFirmwareVersionEntry

#Get the list of HyperflexServerFirmwareVersionEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexServerFirmwareVersionEntryByOrg = Get-IntersightHyperflexServerFirmwareVersionEntry -Organization $org

#Get the HyperflexServerFirmwareVersionEntry based on query Parameter
$HyperflexServerFirmwareVersionEntryByQueryParam = Get-IntersightHyperflexServerFirmwareVersionEntry -Filter Name eq HyperflexServerFirmwareVersionEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .