$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$base_properties1 = Initialize-IntersightIamLdapbaseproperties -Attribute 'CiscoAvPair' -BaseDn 'DC=QATCSLABTPI02DC=ciscoDC=com' -BindDn 'CN=administratorCN=UsersDC=QATCSLABTPI02DC=ciscoDC=com' -BindMethod 'Anonymous' -Domain 'QATCSLABTPI02.cisco.com' -EnableEncryption 1 -EnableGroupAuthorization 1 -Filter 'sAMAccountName' -GroupAttribute 'memberOf' -NestedGroupSearchDepth 128 -Timeout 180

$dns_parameters1 = Initialize-IntersightIamLdapdnsparameters -SearchForest 'xyz' -SearchDomain 'abc'

$ldap1 = New-IntersightIamLdapPolicy -Organization $organization1 -BaseProperties $base_properties1 -DnsParameters $dns_parameters1 -Name 'ldap1' -Description 'test policy' -Enabled 1 -EnableDns 1 -UserSearchPrecedence 'LocalUserDb'