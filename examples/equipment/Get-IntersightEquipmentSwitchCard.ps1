#Get the EquipmentSwitchCard by Name
$EquipmentSwitchCardByName = Get-IntersightEquipmentSwitchCard -Name EquipmentSwitchCardName

#Get the List of ServerProfiles
$EquipmentSwitchCardList = Get-IntersightEquipmentSwitchCard

#Get the list of EquipmentSwitchCard under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentSwitchCardByOrg = Get-IntersightEquipmentSwitchCard -Organization $org

#Get the EquipmentSwitchCard based on query Parameter
$EquipmentSwitchCardByQueryParam = Get-IntersightEquipmentSwitchCard -Filter Name eq EquipmentSwitchCardName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .