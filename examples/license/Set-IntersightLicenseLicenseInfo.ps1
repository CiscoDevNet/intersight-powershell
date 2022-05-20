#Get the LicenseLicenseInfo to Update

$LicenseLicenseInfo = Get-IntersightLicenseLicenseInfo -Moid '<Replace with Moid>'
$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$LicenseLicenseInfo | Set-IntersightLicenseLicenseInfo -Tags $tags1