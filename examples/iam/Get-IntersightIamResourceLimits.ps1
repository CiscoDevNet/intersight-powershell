#Get the IamResourceLimits by Name
$IamResourceLimitsByName = Get-IntersightIamResourceLimits -Name IamResourceLimitsName

#Get the List of ServerProfiles
$IamResourceLimitsList = Get-IntersightIamResourceLimits

#Get the list of IamResourceLimits under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamResourceLimitsByOrg = Get-IntersightIamResourceLimits -Organization $org

#Get the IamResourceLimits based on query Parameter
$IamResourceLimitsByQueryParam = Get-IntersightIamResourceLimits -Filter Name eq IamResourceLimitsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .