
#Get the IppoolIpLease to delete
$IppoolIpLease = Remove-IntersightIppoolIpLease -Name IppoolIpLeaseName
$IppoolIpLease | Remove-IntersightIppoolIpLease

#Remove the server profile by Moid.
Remove-IntersightIppoolIpLease -Moid 123bc2222287wee
