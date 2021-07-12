#Get the IamSecurityHolder by Name
$IamSecurityHolderByName = Get-IntersightIamSecurityHolder -Name IamSecurityHolderName

#Get the List of ServerProfiles
$IamSecurityHolderList = Get-IntersightIamSecurityHolder

#Get the list of IamSecurityHolder under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamSecurityHolderByOrg = Get-IntersightIamSecurityHolder -Organization $org

#Get the IamSecurityHolder based on query Parameter
$IamSecurityHolderByQueryParam = Get-IntersightIamSecurityHolder -Filter Name eq IamSecurityHolderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .