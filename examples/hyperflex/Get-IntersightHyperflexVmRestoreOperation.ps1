#Get the HyperflexVmRestoreOperation by Name
$HyperflexVmRestoreOperationByName = Get-IntersightHyperflexVmRestoreOperation -Name HyperflexVmRestoreOperationName

#Get the List of ServerProfiles
$HyperflexVmRestoreOperationList = Get-IntersightHyperflexVmRestoreOperation

#Get the list of HyperflexVmRestoreOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVmRestoreOperationByOrg = Get-IntersightHyperflexVmRestoreOperation -Organization $org

#Get the HyperflexVmRestoreOperation based on query Parameter
$HyperflexVmRestoreOperationByQueryParam = Get-IntersightHyperflexVmRestoreOperation -Filter Name eq HyperflexVmRestoreOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .