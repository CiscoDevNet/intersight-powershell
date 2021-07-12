#Get the StorageEnclosureDiskSlotEp by Name
$StorageEnclosureDiskSlotEpByName = Get-IntersightStorageEnclosureDiskSlotEp -Name StorageEnclosureDiskSlotEpName

#Get the List of ServerProfiles
$StorageEnclosureDiskSlotEpList = Get-IntersightStorageEnclosureDiskSlotEp

#Get the list of StorageEnclosureDiskSlotEp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageEnclosureDiskSlotEpByOrg = Get-IntersightStorageEnclosureDiskSlotEp -Organization $org

#Get the StorageEnclosureDiskSlotEp based on query Parameter
$StorageEnclosureDiskSlotEpByQueryParam = Get-IntersightStorageEnclosureDiskSlotEp -Filter Name eq StorageEnclosureDiskSlotEpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .