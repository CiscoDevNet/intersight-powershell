
#Get the ResourceGroup to delete
$ResourceGroup = Get-IntersightResourceGroup -Name ResourceGroupName
$ResourceGroup | Remove-IntersightResourceGroup

#Remove the ResourceGroup by Moid.
Remove-IntersightResourceGroup -Moid '<Replace with Moid>'
