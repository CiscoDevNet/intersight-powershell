
#Get the SdcardPolicy to delete
$SdcardPolicy = Get-IntersightSdcardPolicy -Name SdcardPolicyName
$SdcardPolicy | Remove-IntersightSdcardPolicy

#Remove the SdcardPolicy by Moid.
Remove-IntersightSdcardPolicy -Moid '<Replace with Moid>'
