
#Get the VmediaPolicy to delete
$VmediaPolicy = Remove-IntersightVmediaPolicy -Name VmediaPolicyName
$VmediaPolicy | Remove-IntersightVmediaPolicy

#Remove the server profile by Moid.
Remove-IntersightVmediaPolicy -Moid 123bc2222287wee
