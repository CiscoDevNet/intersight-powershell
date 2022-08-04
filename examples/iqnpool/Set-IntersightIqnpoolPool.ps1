
#Get the IqnpoolPool to Update
$IqnpoolPool = Get-IntersightIqnpoolPool -Name IqnpoolPoolName
$IqnpoolPool | Set-IntersightIqnpoolPool -Description 'Updated description'
