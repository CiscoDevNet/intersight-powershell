#Get the VmediaPolicy to delete
$VmediaPolicy = Get-IntersightVmediaPolicy -Name VmediaPolicyName
$VmediaPolicy | Remove-IntersightVmediaPolicy

#Remove the VmediaPolicy by Moid.
Remove-IntersightVmediaPolicy -Moid '<Replace with Moid>'

