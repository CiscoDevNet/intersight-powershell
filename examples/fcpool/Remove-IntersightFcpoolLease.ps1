
#Get the FcpoolLease to delete
$FcpoolLease = Remove-IntersightFcpoolLease -Name FcpoolLeaseName
$FcpoolLease | Remove-IntersightFcpoolLease

#Remove the server profile by Moid.
Remove-IntersightFcpoolLease -Moid 123bc2222287wee
