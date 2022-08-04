#Get the EquipmentIdentitySummary by Name
$EquipmentIdentitySummaryByName = Get-IntersightEquipmentIdentitySummary -Name EquipmentIdentitySummaryName

#Get the List of ServerProfiles
$EquipmentIdentitySummaryList = Get-IntersightEquipmentIdentitySummary

#Get the list of EquipmentIdentitySummary under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentIdentitySummaryByOrg = Get-IntersightEquipmentIdentitySummary -Organization $org

#Get the EquipmentIdentitySummary based on query Parameter
$EquipmentIdentitySummaryByQueryParam = Get-IntersightEquipmentIdentitySummary -Filter Name eq EquipmentIdentitySummaryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .