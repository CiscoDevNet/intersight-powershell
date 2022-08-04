
#Get the IppoolPool to delete
$IppoolPool = Get-IntersightIppoolPool -Name IppoolPoolName
$IppoolPool | Remove-IntersightIppoolPool

#Remove the IppoolPool by Moid.
Remove-IntersightIppoolPool -Moid '<Replace with Moid>'
