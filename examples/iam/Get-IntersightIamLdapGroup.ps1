#Get the IamLdapGroup by Name
$IamLdapGroupByName = Get-IntersightIamLdapGroup -Name IamLdapGroupName

#Get the List of ServerProfiles
$IamLdapGroupList = Get-IntersightIamLdapGroup

#Get the list of IamLdapGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamLdapGroupByOrg = Get-IntersightIamLdapGroup -Organization $org

#Get the IamLdapGroup based on query Parameter
$IamLdapGroupByQueryParam = Get-IntersightIamLdapGroup -Filter Name eq IamLdapGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .