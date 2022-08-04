#Get the HyperflexVmSnapshotInfo by Name
$HyperflexVmSnapshotInfoByName = Get-IntersightHyperflexVmSnapshotInfo -Name HyperflexVmSnapshotInfoName

#Get the List of ServerProfiles
$HyperflexVmSnapshotInfoList = Get-IntersightHyperflexVmSnapshotInfo

#Get the list of HyperflexVmSnapshotInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVmSnapshotInfoByOrg = Get-IntersightHyperflexVmSnapshotInfo -Organization $org

#Get the HyperflexVmSnapshotInfo based on query Parameter
$HyperflexVmSnapshotInfoByQueryParam = Get-IntersightHyperflexVmSnapshotInfo -Filter Name eq HyperflexVmSnapshotInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .