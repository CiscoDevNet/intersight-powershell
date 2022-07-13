#Get the StorageDiskSlot by Name
$StorageDiskSlotByName = Get-IntersightStorageDiskSlot -Name StorageDiskSlotName

#Get the List of ServerProfiles
$StorageDiskSlotList = Get-IntersightStorageDiskSlot

#Get the list of StorageDiskSlot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageDiskSlotByOrg = Get-IntersightStorageDiskSlot -Organization $org

#Get the StorageDiskSlot based on query Parameter
$StorageDiskSlotByQueryParam = Get-IntersightStorageDiskSlot -Filter Name eq StorageDiskSlotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .