#Get the EquipmentLocatorLed by Name
$EquipmentLocatorLedByName = Get-IntersightEquipmentLocatorLed -Name EquipmentLocatorLedName

#Get the List of ServerProfiles
$EquipmentLocatorLedList = Get-IntersightEquipmentLocatorLed

#Get the list of EquipmentLocatorLed under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentLocatorLedByOrg = Get-IntersightEquipmentLocatorLed -Organization $org

#Get the EquipmentLocatorLed based on query Parameter
$EquipmentLocatorLedByQueryParam = Get-IntersightEquipmentLocatorLed -Filter Name eq EquipmentLocatorLedName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .