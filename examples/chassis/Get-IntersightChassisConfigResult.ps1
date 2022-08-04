#Get the ChassisConfigResult by Name
$ChassisConfigResultByName = Get-IntersightChassisConfigResult -Name ChassisConfigResultName

#Get the List of ServerProfiles
$ChassisConfigResultList = Get-IntersightChassisConfigResult

#Get the list of ChassisConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ChassisConfigResultByOrg = Get-IntersightChassisConfigResult -Organization $org

#Get the ChassisConfigResult based on query Parameter
$ChassisConfigResultByQueryParam = Get-IntersightChassisConfigResult -Filter Name eq ChassisConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .