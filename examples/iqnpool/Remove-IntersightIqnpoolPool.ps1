
#Get the IqnpoolPool to delete
$IqnpoolPool = Remove-IntersightIqnpoolPool -Name IqnpoolPoolName
$IqnpoolPool | Remove-IntersightIqnpoolPool

#Remove the server profile by Moid.
Remove-IntersightIqnpoolPool -Moid 123bc2222287wee
