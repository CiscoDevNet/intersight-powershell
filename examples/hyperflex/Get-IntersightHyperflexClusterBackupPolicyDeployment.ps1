#Get the HyperflexClusterBackupPolicyDeployment by Name
$HyperflexClusterBackupPolicyDeploymentByName = Get-IntersightHyperflexClusterBackupPolicyDeployment -Name HyperflexClusterBackupPolicyDeploymentName

#Get the List of ServerProfiles
$HyperflexClusterBackupPolicyDeploymentList = Get-IntersightHyperflexClusterBackupPolicyDeployment

#Get the list of HyperflexClusterBackupPolicyDeployment under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterBackupPolicyDeploymentByOrg = Get-IntersightHyperflexClusterBackupPolicyDeployment -Organization $org

#Get the HyperflexClusterBackupPolicyDeployment based on query Parameter
$HyperflexClusterBackupPolicyDeploymentByQueryParam = Get-IntersightHyperflexClusterBackupPolicyDeployment -Filter Name eq HyperflexClusterBackupPolicyDeploymentName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .