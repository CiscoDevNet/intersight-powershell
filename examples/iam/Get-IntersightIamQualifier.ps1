#Get the IamQualifier by Name
$IamQualifierByName = Get-IntersightIamQualifier -Name IamQualifierName

#Get the List of ServerProfiles
$IamQualifierList = Get-IntersightIamQualifier

#Get the list of IamQualifier under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamQualifierByOrg = Get-IntersightIamQualifier -Organization $org

#Get the IamQualifier based on query Parameter
$IamQualifierByQueryParam = Get-IntersightIamQualifier -Filter Name eq IamQualifierName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .