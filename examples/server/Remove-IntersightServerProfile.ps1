
#Get the ServerProfile to delete
$ServerProfile = Get-IntersightServerProfile -Name ServerProfileName
$ServerProfile | Remove-IntersightServerProfile

#Remove the server profile by Moid.
Remove-IntersightServerProfile -Moid '<Replace with Moid>'
