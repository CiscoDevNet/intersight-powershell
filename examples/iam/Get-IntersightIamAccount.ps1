#Get the IamAccount by Name
$IamAccountByName = Get-IntersightIamAccount -Name IamAccountName

#Get the List of ServerProfiles
$IamAccountList = Get-IntersightIamAccount

#Get the list of IamAccount under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamAccountByOrg = Get-IntersightIamAccount -Organization $org

#Get the IamAccount based on query Parameter
$IamAccountByQueryParam = Get-IntersightIamAccount -Filter Name eq IamAccountName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .