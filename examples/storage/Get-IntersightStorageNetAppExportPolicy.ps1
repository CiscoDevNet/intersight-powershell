#Get the StorageNetAppExportPolicy by Name
$StorageNetAppExportPolicyByName = Get-IntersightStorageNetAppExportPolicy -Name StorageNetAppExportPolicyName

#Get the List of ServerProfiles
$StorageNetAppExportPolicyList = Get-IntersightStorageNetAppExportPolicy

#Get the list of StorageNetAppExportPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppExportPolicyByOrg = Get-IntersightStorageNetAppExportPolicy -Organization $org

#Get the StorageNetAppExportPolicy based on query Parameter
$StorageNetAppExportPolicyByQueryParam = Get-IntersightStorageNetAppExportPolicy -Filter Name eq StorageNetAppExportPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .