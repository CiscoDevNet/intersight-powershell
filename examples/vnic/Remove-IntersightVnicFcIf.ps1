
#Get the VnicFcIf to delete
$VnicFcIf = Get-IntersightVnicFcIf -Name VnicFcIfName
$VnicFcIf | Remove-IntersightVnicFcIf

#Remove the VnicFcIf by Moid.
Remove-IntersightVnicFcIf -Moid '<Replace with Moid>'
