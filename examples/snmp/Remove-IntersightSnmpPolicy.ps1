#Get the SnmpPolicy to delete
$SnmpPolicy = Get-IntersightSnmpPolicy -Name SnmpPolicyName
$SnmpPolicy | Remove-IntersightSnmpPolicy

#Remove the SnmpPolicy by Moid.
Remove-IntersightSnmpPolicy -Moid <Replace with Moid>'
