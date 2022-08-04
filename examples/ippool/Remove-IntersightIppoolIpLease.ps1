
#Get the IppoolIpLease to delete
$IppoolIpLease = Get-IntersightIppoolIpLease -Name IppoolIpLeaseName
$IppoolIpLease | Remove-IntersightIppoolIpLease

#Remove the IppoolIpLease by Moid.
Remove-IntersightIppoolIpLease -Moid '<Replace with Moid>'
