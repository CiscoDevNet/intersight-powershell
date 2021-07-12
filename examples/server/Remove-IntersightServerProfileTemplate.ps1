
#Get the ServerProfileTemplate to delete
$ServerProfileTemplate = Remove-IntersightServerProfileTemplate -Name ServerProfileTemplateName
$ServerProfileTemplate | Remove-IntersightServerProfileTemplate

#Remove the server profile by Moid.
Remove-IntersightServerProfileTemplate -Moid 123bc2222287wee
