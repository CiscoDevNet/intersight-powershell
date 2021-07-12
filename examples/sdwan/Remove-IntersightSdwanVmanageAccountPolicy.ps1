
#Get the SdwanVmanageAccountPolicy to delete
$SdwanVmanageAccountPolicy = Remove-IntersightSdwanVmanageAccountPolicy -Name SdwanVmanageAccountPolicyName
$SdwanVmanageAccountPolicy | Remove-IntersightSdwanVmanageAccountPolicy

#Remove the server profile by Moid.
Remove-IntersightSdwanVmanageAccountPolicy -Moid 123bc2222287wee
