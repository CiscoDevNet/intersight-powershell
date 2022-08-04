#Get the IamDomainGroup by Name
$IamDomainGroupByName = Get-IntersightIamDomainGroup -Name IamDomainGroupName

#Get the List of ServerProfiles
$IamDomainGroupList = Get-IntersightIamDomainGroup

#Get the list of IamDomainGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamDomainGroupByOrg = Get-IntersightIamDomainGroup -Organization $org

#Get the IamDomainGroup based on query Parameter
$IamDomainGroupByQueryParam = Get-IntersightIamDomainGroup -Filter Name eq IamDomainGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .