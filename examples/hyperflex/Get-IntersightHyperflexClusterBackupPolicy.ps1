#Get the HyperflexClusterBackupPolicy by Name
$HyperflexClusterBackupPolicyByName = Get-IntersightHyperflexClusterBackupPolicy -Name HyperflexClusterBackupPolicyName

#Get the List of ServerProfiles
$HyperflexClusterBackupPolicyList = Get-IntersightHyperflexClusterBackupPolicy

#Get the list of HyperflexClusterBackupPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterBackupPolicyByOrg = Get-IntersightHyperflexClusterBackupPolicy -Organization $org

#Get the HyperflexClusterBackupPolicy based on query Parameter
$HyperflexClusterBackupPolicyByQueryParam = Get-IntersightHyperflexClusterBackupPolicy -Filter Name eq HyperflexClusterBackupPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .