
#Get the SnmpPolicy to delete
$SnmpPolicy = Remove-IntersightSnmpPolicy -Name SnmpPolicyName
$SnmpPolicy | Remove-IntersightSnmpPolicy

#Remove the server profile by Moid.
Remove-IntersightSnmpPolicy -Moid 123bc2222287wee
