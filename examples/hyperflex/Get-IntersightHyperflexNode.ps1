#Get the HyperflexNode by Name
$HyperflexNodeByName = Get-IntersightHyperflexNode -Name HyperflexNodeName

#Get the List of ServerProfiles
$HyperflexNodeList = Get-IntersightHyperflexNode

#Get the list of HyperflexNode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexNodeByOrg = Get-IntersightHyperflexNode -Organization $org

#Get the HyperflexNode based on query Parameter
$HyperflexNodeByQueryParam = Get-IntersightHyperflexNode -Filter Name eq HyperflexNodeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .