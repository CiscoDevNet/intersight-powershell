
#Get the VmrcConsole to delete
$VmrcConsole = Remove-IntersightVmrcConsole -Name VmrcConsoleName
$VmrcConsole | Remove-IntersightVmrcConsole

#Remove the server profile by Moid.
Remove-IntersightVmrcConsole -Moid 123bc2222287wee
