
#Get the SdwanRouterNode to delete
$SdwanRouterNode = Remove-IntersightSdwanRouterNode -Name SdwanRouterNodeName
$SdwanRouterNode | Remove-IntersightSdwanRouterNode

#Remove the server profile by Moid.
Remove-IntersightSdwanRouterNode -Moid 123bc2222287wee
