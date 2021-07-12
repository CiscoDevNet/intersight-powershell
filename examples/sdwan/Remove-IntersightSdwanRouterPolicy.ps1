
#Get the SdwanRouterPolicy to delete
$SdwanRouterPolicy = Remove-IntersightSdwanRouterPolicy -Name SdwanRouterPolicyName
$SdwanRouterPolicy | Remove-IntersightSdwanRouterPolicy

#Remove the server profile by Moid.
Remove-IntersightSdwanRouterPolicy -Moid 123bc2222287wee
