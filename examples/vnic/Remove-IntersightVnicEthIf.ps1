
#Get the VnicEthIf to delete
$VnicEthIf = Get-IntersightVnicEthIf -Name VnicEthIfName
$VnicEthIf | Remove-IntersightVnicEthIf

#Remove the VnicEthIf by Moid.
Remove-IntersightVnicEthIf -Moid '<Replace with Moid>'
