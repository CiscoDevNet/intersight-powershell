#Get the EquipmentDeviceSummary by Name
$EquipmentDeviceSummaryByName = Get-IntersightEquipmentDeviceSummary -Name EquipmentDeviceSummaryName

#Get the List of ServerProfiles
$EquipmentDeviceSummaryList = Get-IntersightEquipmentDeviceSummary

#Get the list of EquipmentDeviceSummary under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentDeviceSummaryByOrg = Get-IntersightEquipmentDeviceSummary -Organization $org

#Get the EquipmentDeviceSummary based on query Parameter
$EquipmentDeviceSummaryByQueryParam = Get-IntersightEquipmentDeviceSummary -Filter Name eq EquipmentDeviceSummaryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .