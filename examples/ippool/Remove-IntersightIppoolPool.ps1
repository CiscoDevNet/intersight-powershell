
#Get the IppoolPool to delete
$IppoolPool = Remove-IntersightIppoolPool -Name IppoolPoolName
$IppoolPool | Remove-IntersightIppoolPool

#Remove the server profile by Moid.
Remove-IntersightIppoolPool -Moid 123bc2222287wee
