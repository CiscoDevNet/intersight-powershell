
#Get the NetworkVlanPortInfo to Update
$NetworkVlanPortInfo = Get-IntersightNetworkVlanPortInfo -Name MacpoolPoolName

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$NetworkVlanPortInfo | Set-IntersightNetworkVlanPortInfo -Tags $tags1