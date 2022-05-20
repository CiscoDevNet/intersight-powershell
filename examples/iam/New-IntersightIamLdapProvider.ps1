$ldap_policy1 = Get-IntersightIamLdappolicy -Moid '<Replace with Moid>'

$iam_ldap_provider1 = New-IntersightIamLdapProvider -LdapPolicy $ldap_policy1 -Port 636 -Server '10.1.1.1'