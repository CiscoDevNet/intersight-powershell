
#Get the IqnpoolPool to delete
$IqnpoolPool = Get-IntersightIqnpoolPool -Name IqnpoolPoolName
$IqnpoolPool | Remove-IntersightIqnpoolPool

#Remove the IqnpoolPool by Moid.
Remove-IntersightIqnpoolPool -Moid '<Replace with Moid>'

