
#Get the UuidpoolPool to delete
$UuidpoolPool = Remove-IntersightUuidpoolPool -Name UuidpoolPoolName
$UuidpoolPool | Remove-IntersightUuidpoolPool

#Remove the server profile by Moid.
Remove-IntersightUuidpoolPool -Moid 123bc2222287wee
