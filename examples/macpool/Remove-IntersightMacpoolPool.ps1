
#Get the MacpoolPool to delete
$MacpoolPool = Remove-IntersightMacpoolPool -Name MacpoolPoolName
$MacpoolPool | Remove-IntersightMacpoolPool

#Remove the server profile by Moid.
Remove-IntersightMacpoolPool -Moid 123bc2222287wee
