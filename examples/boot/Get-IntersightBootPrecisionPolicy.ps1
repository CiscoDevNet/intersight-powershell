#Get the BootPrecisionPolicy by Name
$BootPrecisionPolicyByName = Get-IntersightBootPrecisionPolicy -Name BootPrecisionPolicyName

#Get the List of ServerProfiles
$BootPrecisionPolicyList = Get-IntersightBootPrecisionPolicy

#Get the list of BootPrecisionPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootPrecisionPolicyByOrg = Get-IntersightBootPrecisionPolicy -Organization $org

#Get the BootPrecisionPolicy based on query Parameter
$BootPrecisionPolicyByQueryParam = Get-IntersightBootPrecisionPolicy -Filter Name eq BootPrecisionPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .