#Get the BootPrecisionPolicy to Update

$BootPrecisionPolicy = Get-IntersightBootPrecisionPolicy -Name BootPrecisionPolicy
$BootPrecisionPolicy | Set-IntersightBootPrecisionPolicy -Description 'Boot policy'