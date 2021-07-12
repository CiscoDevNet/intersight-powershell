#Get the CrdCustomResource by Name
$CrdCustomResourceByName = Get-IntersightCrdCustomResource -Name CrdCustomResourceName

#Get the List of ServerProfiles
$CrdCustomResourceList = Get-IntersightCrdCustomResource

#Get the list of CrdCustomResource under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CrdCustomResourceByOrg = Get-IntersightCrdCustomResource -Organization $org

#Get the CrdCustomResource based on query Parameter
$CrdCustomResourceByQueryParam = Get-IntersightCrdCustomResource -Filter Name eq CrdCustomResourceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .