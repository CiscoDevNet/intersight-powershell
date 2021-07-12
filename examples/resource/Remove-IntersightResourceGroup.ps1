
#Get the ResourceGroup to delete
$ResourceGroup = Remove-IntersightResourceGroup -Name ResourceGroupName
$ResourceGroup | Remove-IntersightResourceGroup

#Remove the server profile by Moid.
Remove-IntersightResourceGroup -Moid 123bc2222287wee
