
#Get the SdcardPolicy to delete
$SdcardPolicy = Remove-IntersightSdcardPolicy -Name SdcardPolicyName
$SdcardPolicy | Remove-IntersightSdcardPolicy

#Remove the server profile by Moid.
Remove-IntersightSdcardPolicy -Moid 123bc2222287wee
