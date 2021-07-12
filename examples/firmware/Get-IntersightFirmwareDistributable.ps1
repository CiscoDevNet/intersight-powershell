#Get the FirmwareDistributable by Name
$FirmwareDistributableByName = Get-IntersightFirmwareDistributable -Name FirmwareDistributableName

#Get the List of ServerProfiles
$FirmwareDistributableList = Get-IntersightFirmwareDistributable

#Get the list of FirmwareDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareDistributableByOrg = Get-IntersightFirmwareDistributable -Organization $org

#Get the FirmwareDistributable based on query Parameter
$FirmwareDistributableByQueryParam = Get-IntersightFirmwareDistributable -Filter Name eq FirmwareDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .