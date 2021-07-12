
#Get the FcpoolPool to delete
$FcpoolPool = Remove-IntersightFcpoolPool -Name FcpoolPoolName
$FcpoolPool | Remove-IntersightFcpoolPool

#Remove the server profile by Moid.
Remove-IntersightFcpoolPool -Moid 123bc2222287wee
