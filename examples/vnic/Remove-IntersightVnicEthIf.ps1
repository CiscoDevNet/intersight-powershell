
#Get the VnicEthIf to delete
$VnicEthIf = Remove-IntersightVnicEthIf -Name VnicEthIfName
$VnicEthIf | Remove-IntersightVnicEthIf

#Remove the server profile by Moid.
Remove-IntersightVnicEthIf -Moid 123bc2222287wee
