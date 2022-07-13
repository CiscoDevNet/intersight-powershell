#Get the IamSessionLimits by Name
$IamSessionLimitsByName = Get-IntersightIamSessionLimits -Name IamSessionLimitsName

#Get the List of ServerProfiles
$IamSessionLimitsList = Get-IntersightIamSessionLimits

#Get the list of IamSessionLimits under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamSessionLimitsByOrg = Get-IntersightIamSessionLimits -Organization $org

#Get the IamSessionLimits based on query Parameter
$IamSessionLimitsByQueryParam = Get-IntersightIamSessionLimits -Filter Name eq IamSessionLimitsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .