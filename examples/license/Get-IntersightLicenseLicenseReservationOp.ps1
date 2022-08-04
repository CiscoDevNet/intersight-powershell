#Get the LicenseLicenseReservationOp by Name
$LicenseLicenseReservationOpByName = Get-IntersightLicenseLicenseReservationOp -Name LicenseLicenseReservationOpName

#Get the List of ServerProfiles
$LicenseLicenseReservationOpList = Get-IntersightLicenseLicenseReservationOp

#Get the list of LicenseLicenseReservationOp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseLicenseReservationOpByOrg = Get-IntersightLicenseLicenseReservationOp -Organization $org

#Get the LicenseLicenseReservationOp based on query Parameter
$LicenseLicenseReservationOpByQueryParam = Get-IntersightLicenseLicenseReservationOp -Filter Name eq LicenseLicenseReservationOpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .