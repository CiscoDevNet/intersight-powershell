$account_license_data1 = Get-IntersightLicenseAccountlicensedata -Moid '<Replace with Moid>'

$license_iwo_license_count1 = New-IntersightLicenseIwoLicenseCount -AccountLicenseData $account_license_data1