
#Get the ChassisProfile to delete
$ChassisProfile = Remove-IntersightChassisProfile -Name ChassisProfileName
$ChassisProfile | Remove-IntersightChassisProfile

#Remove the server profile by Moid.
Remove-IntersightChassisProfile -Moid 123bc2222287wee
