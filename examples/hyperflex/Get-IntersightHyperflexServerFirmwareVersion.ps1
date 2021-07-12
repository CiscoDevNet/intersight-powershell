#Get the HyperflexServerFirmwareVersion by Name
$HyperflexServerFirmwareVersionByName = Get-IntersightHyperflexServerFirmwareVersion -Name HyperflexServerFirmwareVersionName

#Get the List of ServerProfiles
$HyperflexServerFirmwareVersionList = Get-IntersightHyperflexServerFirmwareVersion

#Get the list of HyperflexServerFirmwareVersion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexServerFirmwareVersionByOrg = Get-IntersightHyperflexServerFirmwareVersion -Organization $org

#Get the HyperflexServerFirmwareVersion based on query Parameter
$HyperflexServerFirmwareVersionByQueryParam = Get-IntersightHyperflexServerFirmwareVersion -Filter Name eq HyperflexServerFirmwareVersionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .