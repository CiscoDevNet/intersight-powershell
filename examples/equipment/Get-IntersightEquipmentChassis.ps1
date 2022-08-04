#Get the EquipmentChassis by Name
$EquipmentChassisByName = Get-IntersightEquipmentChassis -Name EquipmentChassisName

#Get the List of ServerProfiles
$EquipmentChassisList = Get-IntersightEquipmentChassis

#Get the list of EquipmentChassis under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentChassisByOrg = Get-IntersightEquipmentChassis -Organization $org

#Get the EquipmentChassis based on query Parameter
$EquipmentChassisByQueryParam = Get-IntersightEquipmentChassis -Filter Name eq EquipmentChassisName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .