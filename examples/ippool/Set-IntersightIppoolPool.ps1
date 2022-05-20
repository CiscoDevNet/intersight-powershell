
#Get the IppoolPool to Update
$IppoolPool = Get-IntersightIppoolPool -Name IppoolPoolName
$IppoolPool | Set-IntersightIppoolPool -Description 'Updated description'