
#Get the SdcardPolicy to Update
$SdcardPolicy = Get-IntersightSdcardPolicy -Name SdcardPolicyName
$SdcardPolicy | Set-IntersightSdcardPolicy -Description 'Updated description'