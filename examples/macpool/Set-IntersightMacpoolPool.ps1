
#Get the MacpoolPool to Update
$MacpoolPool = Get-IntersightMacpoolPool -Name MacpoolPoolName

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$MacpoolPool | Set-IntersightMacpoolPool -Tags $tags1