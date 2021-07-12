#Get the IamPrivateKeySpec by Name
$IamPrivateKeySpecByName = Get-IntersightIamPrivateKeySpec -Name IamPrivateKeySpecName

#Get the List of ServerProfiles
$IamPrivateKeySpecList = Get-IntersightIamPrivateKeySpec

#Get the list of IamPrivateKeySpec under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamPrivateKeySpecByOrg = Get-IntersightIamPrivateKeySpec -Organization $org

#Get the IamPrivateKeySpec based on query Parameter
$IamPrivateKeySpecByQueryParam = Get-IntersightIamPrivateKeySpec -Filter Name eq IamPrivateKeySpecName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .