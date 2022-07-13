#Get the EquipmentTransceiver by Name
$EquipmentTransceiverByName = Get-IntersightEquipmentTransceiver -Name EquipmentTransceiverName

#Get the List of ServerProfiles
$EquipmentTransceiverList = Get-IntersightEquipmentTransceiver

#Get the list of EquipmentTransceiver under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentTransceiverByOrg = Get-IntersightEquipmentTransceiver -Organization $org

#Get the EquipmentTransceiver based on query Parameter
$EquipmentTransceiverByQueryParam = Get-IntersightEquipmentTransceiver -Filter Name eq EquipmentTransceiverName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .