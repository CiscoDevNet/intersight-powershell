#Get the IamIdp by Name
$IamIdpByName = Get-IntersightIamIdp -Name IamIdpName

#Get the List of ServerProfiles
$IamIdpList = Get-IntersightIamIdp

#Get the list of IamIdp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamIdpByOrg = Get-IntersightIamIdp -Organization $org

#Get the IamIdp based on query Parameter
$IamIdpByQueryParam = Get-IntersightIamIdp -Filter Name eq IamIdpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .