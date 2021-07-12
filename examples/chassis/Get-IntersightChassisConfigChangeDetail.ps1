#Get the ChassisConfigChangeDetail by Name
$ChassisConfigChangeDetailByName = Get-IntersightChassisConfigChangeDetail -Name ChassisConfigChangeDetailName

#Get the List of ServerProfiles
$ChassisConfigChangeDetailList = Get-IntersightChassisConfigChangeDetail

#Get the list of ChassisConfigChangeDetail under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ChassisConfigChangeDetailByOrg = Get-IntersightChassisConfigChangeDetail -Organization $org

#Get the ChassisConfigChangeDetail based on query Parameter
$ChassisConfigChangeDetailByQueryParam = Get-IntersightChassisConfigChangeDetail -Filter Name eq ChassisConfigChangeDetailName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .