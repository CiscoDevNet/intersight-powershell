#Get the ChassisConfigResultEntry by Name
$ChassisConfigResultEntryByName = Get-IntersightChassisConfigResultEntry -Name ChassisConfigResultEntryName

#Get the List of ServerProfiles
$ChassisConfigResultEntryList = Get-IntersightChassisConfigResultEntry

#Get the list of ChassisConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ChassisConfigResultEntryByOrg = Get-IntersightChassisConfigResultEntry -Organization $org

#Get the ChassisConfigResultEntry based on query Parameter
$ChassisConfigResultEntryByQueryParam = Get-IntersightChassisConfigResultEntry -Filter Name eq ChassisConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .