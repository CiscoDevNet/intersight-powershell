
#Get the NetworkconfigPolicy to Update
$NetworkconfigPolicy = Get-IntersightNetworkconfigPolicy -Name NetworkconfigPolicyName
$NetworkconfigPolicy | Set-IntersightNetworkconfigPolicy -Description 'Updated description'