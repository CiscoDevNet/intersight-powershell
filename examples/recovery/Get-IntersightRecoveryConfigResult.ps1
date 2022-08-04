#Get the RecoveryConfigResult by Name
$RecoveryConfigResultByName = Get-IntersightRecoveryConfigResult -Name RecoveryConfigResultName

#Get the List of ServerProfiles
$RecoveryConfigResultList = Get-IntersightRecoveryConfigResult

#Get the list of RecoveryConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryConfigResultByOrg = Get-IntersightRecoveryConfigResult -Organization $org

#Get the RecoveryConfigResult based on query Parameter
$RecoveryConfigResultByQueryParam = Get-IntersightRecoveryConfigResult -Filter Name eq RecoveryConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .