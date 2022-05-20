
#Get the FcpoolLease to delete
$FcpoolLease = Get-IntersightFcpoolLease -Name FcpoolLeaseName
$FcpoolLease | Remove-IntersightFcpoolLease

#Remove the FcpoolLease by Moid.
Remove-IntersightFcpoolLease -Moid '<Replace with Moid>'

