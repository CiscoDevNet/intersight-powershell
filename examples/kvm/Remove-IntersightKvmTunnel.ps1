
#Get the KvmTunnel to delete
$KvmTunnel = Remove-IntersightKvmTunnel -Name KvmTunnelName
$KvmTunnel | Remove-IntersightKvmTunnel

#Remove the server profile by Moid.
Remove-IntersightKvmTunnel -Moid 123bc2222287wee
