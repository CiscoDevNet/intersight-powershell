#Get the FirmwareFirmwareSummary by Name
$FirmwareFirmwareSummaryByName = Get-IntersightFirmwareFirmwareSummary -Name FirmwareFirmwareSummaryName

#Get the List of ServerProfiles
$FirmwareFirmwareSummaryList = Get-IntersightFirmwareFirmwareSummary

#Get the list of FirmwareFirmwareSummary under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareFirmwareSummaryByOrg = Get-IntersightFirmwareFirmwareSummary -Organization $org

#Get the FirmwareFirmwareSummary based on query Parameter
$FirmwareFirmwareSummaryByQueryParam = Get-IntersightFirmwareFirmwareSummary -Filter Name eq FirmwareFirmwareSummaryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .