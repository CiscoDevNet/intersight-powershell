#Get the StoragePureDisk by Name
$StoragePureDiskByName = Get-IntersightStoragePureDisk -Name StoragePureDiskName

#Get the List of ServerProfiles
$StoragePureDiskList = Get-IntersightStoragePureDisk

#Get the list of StoragePureDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureDiskByOrg = Get-IntersightStoragePureDisk -Organization $org

#Get the StoragePureDisk based on query Parameter
$StoragePureDiskByQueryParam = Get-IntersightStoragePureDisk -Filter Name eq StoragePureDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .