
#Get the MacpoolLease to delete
$MacpoolLease = Remove-IntersightMacpoolLease -Name MacpoolLeaseName
$MacpoolLease | Remove-IntersightMacpoolLease

#Remove the server profile by Moid.
Remove-IntersightMacpoolLease -Moid 123bc2222287wee
