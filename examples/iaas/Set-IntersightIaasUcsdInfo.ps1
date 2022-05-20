
#Get the IaasUcsdInfo to Update
$IaasUcsdInfo = Get-IntersightIaasUcsdInfo -Name IaasUcsdInfoName
$tags1 = Initialize-IntersightMoTag -Key 'key' -Value 'value'
$IaasUcsdInfo | Set-IntersightIaasUcsdInfo -tags $tags1
