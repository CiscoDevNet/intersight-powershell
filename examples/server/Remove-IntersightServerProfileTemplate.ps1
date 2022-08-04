
#Get the ServerProfileTemplate to delete
$ServerProfileTemplate = Get-IntersightServerProfileTemplate -Name ServerProfileTemplateName
$ServerProfileTemplate | Remove-IntersightServerProfileTemplate

#Remove the ServerProfileTemplate  by Moid.
Remove-IntersightServerProfileTemplate -Moid '<Replace with Moid>'
