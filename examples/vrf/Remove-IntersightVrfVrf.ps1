
#Get the VrfVrf to delete
$VrfVrf = Remove-IntersightVrfVrf -Name VrfVrfName
$VrfVrf | Remove-IntersightVrfVrf

#Remove the server profile by Moid.
Remove-IntersightVrfVrf -Moid 123bc2222287wee
