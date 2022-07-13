#Get the RecoveryScheduleConfigPolicy by Name
$RecoveryScheduleConfigPolicyByName = Get-IntersightRecoveryScheduleConfigPolicy -Name RecoveryScheduleConfigPolicyName

#Get the List of ServerProfiles
$RecoveryScheduleConfigPolicyList = Get-IntersightRecoveryScheduleConfigPolicy

#Get the list of RecoveryScheduleConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryScheduleConfigPolicyByOrg = Get-IntersightRecoveryScheduleConfigPolicy -Organization $org

#Get the RecoveryScheduleConfigPolicy based on query Parameter
$RecoveryScheduleConfigPolicyByQueryParam = Get-IntersightRecoveryScheduleConfigPolicy -Filter Name eq RecoveryScheduleConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .