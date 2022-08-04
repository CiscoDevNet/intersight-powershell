
#Get the MacpoolLease to delete
$MacpoolLease = Get-IntersightMacpoolLease -Name MacpoolLeaseName
$MacpoolLease | Remove-IntersightMacpoolLease

#Remove the MacpoolLease by Moid.
Remove-IntersightMacpoolLease -Moid '<Replace with Moid>'
