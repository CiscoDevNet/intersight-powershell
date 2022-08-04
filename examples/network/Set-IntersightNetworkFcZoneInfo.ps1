
#Get the NetworkFcZoneInfo to Update
$NetworkFcZoneInfo = Get-IntersightNetworkFcZoneInfo -Name MacpoolPoolName

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$NetworkFcZoneInfo | Set-IntersightNetworkFcZoneInfo -Tags $tags1