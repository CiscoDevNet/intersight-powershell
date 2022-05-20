
#Get the BootPrecisionPolicy to delete
$BootPrecisionPolicy = Get-IntersightBootPrecisionPolicy -Name BootPrecisionPolicyName
$BootPrecisionPolicy | Remove-IntersightBootPrecisionPolicy

#Remove the BootPrecisionPolicy by Moid.
Remove-IntersightBootPrecisionPolicy -Moid '<Replace with Moid>'
