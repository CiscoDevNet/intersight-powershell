#Get the FirmwareEula by Name
$FirmwareEulaByName = Get-IntersightFirmwareEula -Name FirmwareEulaName

#Get the List of ServerProfiles
$FirmwareEulaList = Get-IntersightFirmwareEula

#Get the list of FirmwareEula under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareEulaByOrg = Get-IntersightFirmwareEula -Organization $org

#Get the FirmwareEula based on query Parameter
$FirmwareEulaByQueryParam = Get-IntersightFirmwareEula -Filter Name eq FirmwareEulaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .