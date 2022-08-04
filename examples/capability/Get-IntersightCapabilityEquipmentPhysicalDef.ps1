#Get the CapabilityEquipmentPhysicalDef by Name
$CapabilityEquipmentPhysicalDefByName = Get-IntersightCapabilityEquipmentPhysicalDef -Name CapabilityEquipmentPhysicalDefName

#Get the List of ServerProfiles
$CapabilityEquipmentPhysicalDefList = Get-IntersightCapabilityEquipmentPhysicalDef

#Get the list of CapabilityEquipmentPhysicalDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityEquipmentPhysicalDefByOrg = Get-IntersightCapabilityEquipmentPhysicalDef -Organization $org

#Get the CapabilityEquipmentPhysicalDef based on query Parameter
$CapabilityEquipmentPhysicalDefByQueryParam = Get-IntersightCapabilityEquipmentPhysicalDef -Filter Name eq CapabilityEquipmentPhysicalDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .