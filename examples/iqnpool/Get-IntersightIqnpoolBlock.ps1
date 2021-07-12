#Get the IqnpoolBlock by Name
$IqnpoolBlockByName = Get-IntersightIqnpoolBlock -Name IqnpoolBlockName

#Get the List of ServerProfiles
$IqnpoolBlockList = Get-IntersightIqnpoolBlock

#Get the list of IqnpoolBlock under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IqnpoolBlockByOrg = Get-IntersightIqnpoolBlock -Organization $org

#Get the IqnpoolBlock based on query Parameter
$IqnpoolBlockByQueryParam = Get-IntersightIqnpoolBlock -Filter Name eq IqnpoolBlockName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .