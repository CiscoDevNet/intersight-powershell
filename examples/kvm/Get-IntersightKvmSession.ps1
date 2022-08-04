#Get the KvmSession by Name
$KvmSessionByName = Get-IntersightKvmSession -Name KvmSessionName

#Get the List of ServerProfiles
$KvmSessionList = Get-IntersightKvmSession

#Get the list of KvmSession under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KvmSessionByOrg = Get-IntersightKvmSession -Organization $org

#Get the KvmSession based on query Parameter
$KvmSessionByQueryParam = Get-IntersightKvmSession -Filter Name eq KvmSessionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .