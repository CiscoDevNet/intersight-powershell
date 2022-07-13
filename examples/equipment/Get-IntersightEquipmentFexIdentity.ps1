#Get the EquipmentFexIdentity by Name
$EquipmentFexIdentityByName = Get-IntersightEquipmentFexIdentity -Name EquipmentFexIdentityName

#Get the List of ServerProfiles
$EquipmentFexIdentityList = Get-IntersightEquipmentFexIdentity

#Get the list of EquipmentFexIdentity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentFexIdentityByOrg = Get-IntersightEquipmentFexIdentity -Organization $org

#Get the EquipmentFexIdentity based on query Parameter
$EquipmentFexIdentityByQueryParam = Get-IntersightEquipmentFexIdentity -Filter Name eq EquipmentFexIdentityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .