#Get the UuidpoolPool to delete
$UuidpoolPool = Get-IntersightUuidpoolPool -Name UuidpoolPoolName
$UuidpoolPool | Remove-IntersightUuidpoolPool

#Remove the UuidpoolPool by Moid.
Remove-IntersightUuidpoolPool -Moid '<Replace with Moid>'
