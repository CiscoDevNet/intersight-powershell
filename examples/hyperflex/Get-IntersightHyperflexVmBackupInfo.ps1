#Get the HyperflexVmBackupInfo by Name
$HyperflexVmBackupInfoByName = Get-IntersightHyperflexVmBackupInfo -Name HyperflexVmBackupInfoName

#Get the List of ServerProfiles
$HyperflexVmBackupInfoList = Get-IntersightHyperflexVmBackupInfo

#Get the list of HyperflexVmBackupInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVmBackupInfoByOrg = Get-IntersightHyperflexVmBackupInfo -Organization $org

#Get the HyperflexVmBackupInfo based on query Parameter
$HyperflexVmBackupInfoByQueryParam = Get-IntersightHyperflexVmBackupInfo -Filter Name eq HyperflexVmBackupInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .