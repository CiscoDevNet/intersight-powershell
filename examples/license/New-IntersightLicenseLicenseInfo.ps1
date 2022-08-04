$tags1 = Initialize-IntersightMoTag -Key 'main_license' -Value 'license_license_info1'

$license_license_info1 = New-IntersightLicenseLicenseInfo -Tags $tags1 -EvaluationPeriod 30 -ExtraEvaluation 15