#Get the LsServiceProfile to Update

$LsServiceProfile = Get-IntersightLsServiceProfile -Moid '<Replace with Moid>'
$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$LsServiceProfile | Set-IntersightLsServiceProfile -Tags $tags1