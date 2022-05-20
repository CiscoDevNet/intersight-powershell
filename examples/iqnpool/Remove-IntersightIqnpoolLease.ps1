
#Get the IqnpoolLease to delete
$IqnpoolLease = Get-IntersightIqnpoolLease -Name IqnpoolLeaseName
$IqnpoolLease | Remove-IntersightIqnpoolLease

#Remove the IqnpoolLease by Moid.
Remove-IntersightIqnpoolLease -Moid '<Replace with Moid>'

