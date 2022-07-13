#Get the IamIdpReference by Name
$IamIdpReferenceByName = Get-IntersightIamIdpReference -Name IamIdpReferenceName

#Get the List of ServerProfiles
$IamIdpReferenceList = Get-IntersightIamIdpReference

#Get the list of IamIdpReference under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamIdpReferenceByOrg = Get-IntersightIamIdpReference -Organization $org

#Get the IamIdpReference based on query Parameter
$IamIdpReferenceByQueryParam = Get-IntersightIamIdpReference -Filter Name eq IamIdpReferenceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .