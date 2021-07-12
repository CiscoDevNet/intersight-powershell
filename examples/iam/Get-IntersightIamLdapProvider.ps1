#Get the IamLdapProvider by Name
$IamLdapProviderByName = Get-IntersightIamLdapProvider -Name IamLdapProviderName

#Get the List of ServerProfiles
$IamLdapProviderList = Get-IntersightIamLdapProvider

#Get the list of IamLdapProvider under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamLdapProviderByOrg = Get-IntersightIamLdapProvider -Organization $org

#Get the IamLdapProvider based on query Parameter
$IamLdapProviderByQueryParam = Get-IntersightIamLdapProvider -Filter Name eq IamLdapProviderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .