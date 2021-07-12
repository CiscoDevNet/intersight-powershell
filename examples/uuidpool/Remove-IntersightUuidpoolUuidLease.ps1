
#Get the UuidpoolUuidLease to delete
$UuidpoolUuidLease = Remove-IntersightUuidpoolUuidLease -Name UuidpoolUuidLeaseName
$UuidpoolUuidLease | Remove-IntersightUuidpoolUuidLease

#Remove the server profile by Moid.
Remove-IntersightUuidpoolUuidLease -Moid 123bc2222287wee
