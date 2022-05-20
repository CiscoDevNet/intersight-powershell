
#Get the ServerProfile to Update
$ServerProfile = Get-IntersightServerProfile -Name ServerProfileName
$ServerProfile | Set-IntersightServerProfile -Description 'Updated description'
