
#Get the ChassisProfile to Update
$ChassisProfile = Get-IntersightChassisProfile -Name ChassisProfileName
$ChassisProfile | Set-IntersightChassisProfile -Description 'Updated description'
