#Get the IamApiKey by Name
$IamApiKeyByName = Get-IntersightIamApiKey -Name IamApiKeyName

#Get the List of ServerProfiles
$IamApiKeyList = Get-IntersightIamApiKey

#Get the list of IamApiKey under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamApiKeyByOrg = Get-IntersightIamApiKey -Organization $org

#Get the IamApiKey based on query Parameter
$IamApiKeyByQueryParam = Get-IntersightIamApiKey -Filter Name eq IamApiKeyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .