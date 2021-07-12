#Get the StorageVdMemberEp by Name
$StorageVdMemberEpByName = Get-IntersightStorageVdMemberEp -Name StorageVdMemberEpName

#Get the List of ServerProfiles
$StorageVdMemberEpList = Get-IntersightStorageVdMemberEp

#Get the list of StorageVdMemberEp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageVdMemberEpByOrg = Get-IntersightStorageVdMemberEp -Organization $org

#Get the StorageVdMemberEp based on query Parameter
$StorageVdMemberEpByQueryParam = Get-IntersightStorageVdMemberEp -Filter Name eq StorageVdMemberEpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .