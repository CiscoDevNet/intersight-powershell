
#Get the ServerProfile to delete
$ServerProfile = Remove-IntersightServerProfile -Name ServerProfileName
$ServerProfile | Remove-IntersightServerProfile

#Remove the server profile by Moid.
Remove-IntersightServerProfile -Moid 123bc2222287wee
