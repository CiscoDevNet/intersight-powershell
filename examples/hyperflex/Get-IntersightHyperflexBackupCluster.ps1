#Get the HyperflexBackupCluster by Name
$HyperflexBackupClusterByName = Get-IntersightHyperflexBackupCluster -Name HyperflexBackupClusterName

#Get the List of ServerProfiles
$HyperflexBackupClusterList = Get-IntersightHyperflexBackupCluster

#Get the list of HyperflexBackupCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexBackupClusterByOrg = Get-IntersightHyperflexBackupCluster -Organization $org

#Get the HyperflexBackupCluster based on query Parameter
$HyperflexBackupClusterByQueryParam = Get-IntersightHyperflexBackupCluster -Filter Name eq HyperflexBackupClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .