#Get the IaasDeviceStatus by Name
$IaasDeviceStatusByName = Get-IntersightIaasDeviceStatus -Name IaasDeviceStatusName

#Get the List of ServerProfiles
$IaasDeviceStatusList = Get-IntersightIaasDeviceStatus

#Get the list of IaasDeviceStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IaasDeviceStatusByOrg = Get-IntersightIaasDeviceStatus -Organization $org

#Get the IaasDeviceStatus based on query Parameter
$IaasDeviceStatusByQueryParam = Get-IntersightIaasDeviceStatus -Filter Name eq IaasDeviceStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .