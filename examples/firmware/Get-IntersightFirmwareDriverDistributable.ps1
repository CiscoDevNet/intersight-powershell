#Get the FirmwareDriverDistributable by Name
$FirmwareDriverDistributableByName = Get-IntersightFirmwareDriverDistributable -Name FirmwareDriverDistributableName

#Get the List of ServerProfiles
$FirmwareDriverDistributableList = Get-IntersightFirmwareDriverDistributable

#Get the list of FirmwareDriverDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareDriverDistributableByOrg = Get-IntersightFirmwareDriverDistributable -Organization $org

#Get the FirmwareDriverDistributable based on query Parameter
$FirmwareDriverDistributableByQueryParam = Get-IntersightFirmwareDriverDistributable -Filter Name eq FirmwareDriverDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .