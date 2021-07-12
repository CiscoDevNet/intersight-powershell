
#Get the VnicFcIf to delete
$VnicFcIf = Remove-IntersightVnicFcIf -Name VnicFcIfName
$VnicFcIf | Remove-IntersightVnicFcIf

#Remove the server profile by Moid.
Remove-IntersightVnicFcIf -Moid 123bc2222287wee
