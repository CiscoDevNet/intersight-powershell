#Get the HyperflexClusterHealthCheckExecutionSnapshot by Name
$HyperflexClusterHealthCheckExecutionSnapshotByName = Get-IntersightHyperflexClusterHealthCheckExecutionSnapshot -Name HyperflexClusterHealthCheckExecutionSnapshotName

#Get the List of ServerProfiles
$HyperflexClusterHealthCheckExecutionSnapshotList = Get-IntersightHyperflexClusterHealthCheckExecutionSnapshot

#Get the list of HyperflexClusterHealthCheckExecutionSnapshot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterHealthCheckExecutionSnapshotByOrg = Get-IntersightHyperflexClusterHealthCheckExecutionSnapshot -Organization $org

#Get the HyperflexClusterHealthCheckExecutionSnapshot based on query Parameter
$HyperflexClusterHealthCheckExecutionSnapshotByQueryParam = Get-IntersightHyperflexClusterHealthCheckExecutionSnapshot -Filter Name eq HyperflexClusterHealthCheckExecutionSnapshotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .