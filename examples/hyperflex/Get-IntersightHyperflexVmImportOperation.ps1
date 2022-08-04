#Get the HyperflexVmImportOperation by Name
$HyperflexVmImportOperationByName = Get-IntersightHyperflexVmImportOperation -Name HyperflexVmImportOperationName

#Get the List of ServerProfiles
$HyperflexVmImportOperationList = Get-IntersightHyperflexVmImportOperation

#Get the list of HyperflexVmImportOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVmImportOperationByOrg = Get-IntersightHyperflexVmImportOperation -Organization $org

#Get the HyperflexVmImportOperation based on query Parameter
$HyperflexVmImportOperationByQueryParam = Get-IntersightHyperflexVmImportOperation -Filter Name eq HyperflexVmImportOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .