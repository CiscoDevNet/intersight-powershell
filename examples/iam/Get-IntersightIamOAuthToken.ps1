#Get the IamOAuthToken by Name
$IamOAuthTokenByName = Get-IntersightIamOAuthToken -Name IamOAuthTokenName

#Get the List of ServerProfiles
$IamOAuthTokenList = Get-IntersightIamOAuthToken

#Get the list of IamOAuthToken under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamOAuthTokenByOrg = Get-IntersightIamOAuthToken -Organization $org

#Get the IamOAuthToken based on query Parameter
$IamOAuthTokenByQueryParam = Get-IntersightIamOAuthToken -Filter Name eq IamOAuthTokenName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .