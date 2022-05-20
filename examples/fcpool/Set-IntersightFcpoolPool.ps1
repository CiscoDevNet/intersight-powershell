
#Get the FcpoolPool to delete
$FcpoolPool = Get-IntersightFcpoolPool -Name FcpoolPoolName
$FcpoolPool | Set-IntersightFcpoolPool -Description 'Updated description'
