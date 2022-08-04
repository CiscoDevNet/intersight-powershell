#Get the IamTrustPoint by Name
$IamTrustPointByName = Get-IntersightIamTrustPoint -Name IamTrustPointName

#Get the List of ServerProfiles
$IamTrustPointList = Get-IntersightIamTrustPoint

#Get the list of IamTrustPoint under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamTrustPointByOrg = Get-IntersightIamTrustPoint -Organization $org

#Get the IamTrustPoint based on query Parameter
$IamTrustPointByQueryParam = Get-IntersightIamTrustPoint -Filter Name eq IamTrustPointName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .