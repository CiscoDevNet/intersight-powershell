#Get the RecoveryConfigResultEntry by Name
$RecoveryConfigResultEntryByName = Get-IntersightRecoveryConfigResultEntry -Name RecoveryConfigResultEntryName

#Get the List of ServerProfiles
$RecoveryConfigResultEntryList = Get-IntersightRecoveryConfigResultEntry

#Get the list of RecoveryConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$RecoveryConfigResultEntryByOrg = Get-IntersightRecoveryConfigResultEntry -Organization $org

#Get the RecoveryConfigResultEntry based on query Parameter
$RecoveryConfigResultEntryByQueryParam = Get-IntersightRecoveryConfigResultEntry -Filter Name eq RecoveryConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .