
#Get the ChassisProfile to delete
$ChassisProfile = Get-IntersightChassisProfile -Name ChassisProfileName
$ChassisProfile | Remove-IntersightChassisProfile

#Remove the ChassisProfile by Moid.
Remove-IntersightChassisProfile -Moid '<Replace with Moid>'

