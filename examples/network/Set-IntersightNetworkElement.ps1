
#Get the NetworkElement to Update
$NetworkElement = Get-IntersightNetworkElement -Name MacpoolPoolName

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$NetworkElement | Set-IntersightNetworkElement -Tags $tags1