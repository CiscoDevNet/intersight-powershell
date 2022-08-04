
#Get the MacpoolPool to delete
$MacpoolPool = Get-IntersightMacpoolPool -Name MacpoolPoolName
$MacpoolPool | Remove-IntersightMacpoolPool

#Remove the MacpoolPool by Moid.
Remove-IntersightMacpoolPool -Moid '<Replace with Moid>'
