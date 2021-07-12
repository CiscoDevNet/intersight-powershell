#Get the FirmwareDistributableMeta by Name
$FirmwareDistributableMetaByName = Get-IntersightFirmwareDistributableMeta -Name FirmwareDistributableMetaName

#Get the List of ServerProfiles
$FirmwareDistributableMetaList = Get-IntersightFirmwareDistributableMeta

#Get the list of FirmwareDistributableMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareDistributableMetaByOrg = Get-IntersightFirmwareDistributableMeta -Organization $org

#Get the FirmwareDistributableMeta based on query Parameter
$FirmwareDistributableMetaByQueryParam = Get-IntersightFirmwareDistributableMeta -Filter Name eq FirmwareDistributableMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .