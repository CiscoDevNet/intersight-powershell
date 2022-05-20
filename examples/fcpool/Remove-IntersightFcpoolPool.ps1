
#Get the FcpoolPool to delete
$FcpoolPool = Get-IntersightFcpoolPool -Name FcpoolPoolName
$FcpoolPool | Remove-IntersightFcpoolPool

#Remove the FcpoolPool by Moid.
Remove-IntersightFcpoolPool -Moid '<Replace with Moid>'

