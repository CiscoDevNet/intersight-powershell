#Get the IamPrivilegeSet by Name
$IamPrivilegeSetByName = Get-IntersightIamPrivilegeSet -Name IamPrivilegeSetName

#Get the List of ServerProfiles
$IamPrivilegeSetList = Get-IntersightIamPrivilegeSet

#Get the list of IamPrivilegeSet under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamPrivilegeSetByOrg = Get-IntersightIamPrivilegeSet -Organization $org

#Get the IamPrivilegeSet based on query Parameter
$IamPrivilegeSetByQueryParam = Get-IntersightIamPrivilegeSet -Filter Name eq IamPrivilegeSetName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .