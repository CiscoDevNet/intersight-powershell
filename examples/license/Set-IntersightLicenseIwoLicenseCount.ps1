#Get the LicenseIwoLicenseCount to Update

$LicenseIwoLicenseCount = Get-IntersightLicenseIwoLicenseCount -Moid '<Replace with Moid>'
$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$LicenseIwoLicenseCount | Set-IntersightLicenseIwoLicenseCount -Tags $tags1