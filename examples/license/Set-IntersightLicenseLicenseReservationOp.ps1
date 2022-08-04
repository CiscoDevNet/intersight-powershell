#Get the LicenseLicenseReservationOp to Update

$LicenseLicenseReservationOp = Get-IntersightLicenseLicenseReservationOp -Moid '<Replace with Moid>'
$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$LicenseLicenseReservationOp | Set-IntersightLicenseLicenseReservationOp -Tags $tags1