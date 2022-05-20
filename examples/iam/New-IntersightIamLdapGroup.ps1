$end_point_role1 = Get-IntersightIamEndpointrole -Moid '<Replace with Moid>'

$ldap_policy1 = Get-IntersightIamLdappolicy -Moid '<Replace with Moid>'

$iam_ldap_group1 = New-IntersightIamLdapGroup -EndPointRole $end_point_role1 -LdapPolicy $ldap_policy1 -Domain '.example.com' -Name 'ldap_group1'