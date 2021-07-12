
#Get the IqnpoolLease to delete
$IqnpoolLease = Remove-IntersightIqnpoolLease -Name IqnpoolLeaseName
$IqnpoolLease | Remove-IntersightIqnpoolLease

#Remove the server profile by Moid.
Remove-IntersightIqnpoolLease -Moid 123bc2222287wee
