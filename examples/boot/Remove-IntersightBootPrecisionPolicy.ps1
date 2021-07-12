
#Get the BootPrecisionPolicy to delete
$BootPrecisionPolicy = Remove-IntersightBootPrecisionPolicy -Name BootPrecisionPolicyName
$BootPrecisionPolicy | Remove-IntersightBootPrecisionPolicy

#Remove the server profile by Moid.
Remove-IntersightBootPrecisionPolicy -Moid 123bc2222287wee
