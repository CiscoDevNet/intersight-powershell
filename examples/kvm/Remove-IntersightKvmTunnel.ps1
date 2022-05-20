
#Get the KvmTunnel to delete
$KvmTunnel = Get-IntersightKvmTunnel -Name KvmTunnelName
$KvmTunnel | Remove-IntersightKvmTunnel

#Remove the KvmTunnel by Moid.
Remove-IntersightKvmTunnel -Moid '<Replace with Moid>'
