
#Get the IamLdapPolicy to Update
$IamLdapPolicy = Get-IntersightIamLdapPolicy -Name IamLdapPolicyName
$IamLdapPolicy | Set-IntersightIamLdapPolicy -Description 'Updated description'