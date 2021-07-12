#Get the EquipmentChassisIdentity by Name
$EquipmentChassisIdentityByName = Get-IntersightEquipmentChassisIdentity -Name EquipmentChassisIdentityName

#Get the List of ServerProfiles
$EquipmentChassisIdentityList = Get-IntersightEquipmentChassisIdentity

#Get the list of EquipmentChassisIdentity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentChassisIdentityByOrg = Get-IntersightEquipmentChassisIdentity -Organization $org

#Get the EquipmentChassisIdentity based on query Parameter
$EquipmentChassisIdentityByQueryParam = Get-IntersightEquipmentChassisIdentity -Filter Name eq EquipmentChassisIdentityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .