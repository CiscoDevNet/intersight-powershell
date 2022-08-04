
#Get the ServerProfileTemplate to Update
$ServerProfileTemplate = Get-IntersightServerProfileTemplate -Name ServerProfileTemplateName
$ServerProfileTemplate | Set-IntersightServerProfileTemplate -Description 'Updated description'
