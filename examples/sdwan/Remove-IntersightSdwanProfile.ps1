
#Get the SdwanProfile to delete
$SdwanProfile = Remove-IntersightSdwanProfile -Name SdwanProfileName
$SdwanProfile | Remove-IntersightSdwanProfile

#Remove the server profile by Moid.
Remove-IntersightSdwanProfile -Moid 123bc2222287wee
