#Get the HyperflexHealthCheckExecutionSnapshot by Name
$HyperflexHealthCheckExecutionSnapshotByName = Get-IntersightHyperflexHealthCheckExecutionSnapshot -Name HyperflexHealthCheckExecutionSnapshotName

#Get the List of ServerProfiles
$HyperflexHealthCheckExecutionSnapshotList = Get-IntersightHyperflexHealthCheckExecutionSnapshot

#Get the list of HyperflexHealthCheckExecutionSnapshot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHealthCheckExecutionSnapshotByOrg = Get-IntersightHyperflexHealthCheckExecutionSnapshot -Organization $org

#Get the HyperflexHealthCheckExecutionSnapshot based on query Parameter
$HyperflexHealthCheckExecutionSnapshotByQueryParam = Get-IntersightHyperflexHealthCheckExecutionSnapshot -Filter Name eq HyperflexHealthCheckExecutionSnapshotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .