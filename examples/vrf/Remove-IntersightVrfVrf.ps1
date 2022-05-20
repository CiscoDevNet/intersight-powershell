#Get the VrfVrf to delete
$VrfVrf = Get-IntersightVrfVrf -Name VrfVrfName
$VrfVrf | Remove-IntersightVrfVrf

#Remove the VrfVrf by Moid.
Remove-IntersightVrfVrf -Moid '<Replace with Moid>'
