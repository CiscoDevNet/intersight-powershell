#Get the HyperflexHxapDvUplink by Name
$HyperflexHxapDvUplinkByName = Get-IntersightHyperflexHxapDvUplink -Name HyperflexHxapDvUplinkName

#Get the List of ServerProfiles
$HyperflexHxapDvUplinkList = Get-IntersightHyperflexHxapDvUplink

#Get the list of HyperflexHxapDvUplink under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHxapDvUplinkByOrg = Get-IntersightHyperflexHxapDvUplink -Organization $org

#Get the HyperflexHxapDvUplink based on query Parameter
$HyperflexHxapDvUplinkByQueryParam = Get-IntersightHyperflexHxapDvUplink -Filter Name eq HyperflexHxapDvUplinkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .