#Get the VmrcConsole to delete
$VmrcConsole = Get-IntersightVmrcConsole -Name VmrcConsoleName
$VmrcConsole | Remove-IntersightVmrcConsole

#Remove the VmrcConsole by Moid.
Remove-IntersightVmrcConsole -Moid '<Replace with Moid>'