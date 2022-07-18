#Get the BootPrecisionPolicy to Update

$BootPrecisionPolicy = Get-IntersightBootPrecisionPolicy -Name BootPrecisionPolicy

$boot_devices5 = Initialize-IntersightBootUsb -Enabled 1 -Name 'usb'
$BootPrecisionPolicy.BootDevices.Add($boot_devices5)

$BootPrecisionPolicy | Set-IntersightBootPrecisionPolicy -Description 'Boot policy' -BootDevices $BootPrecisionPolicy.BootDevices