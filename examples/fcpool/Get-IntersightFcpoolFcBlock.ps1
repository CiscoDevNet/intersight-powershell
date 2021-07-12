#Get the FcpoolFcBlock by Name
$FcpoolFcBlockByName = Get-IntersightFcpoolFcBlock -Name FcpoolFcBlockName

#Get the List of ServerProfiles
$FcpoolFcBlockList = Get-IntersightFcpoolFcBlock

#Get the list of FcpoolFcBlock under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FcpoolFcBlockByOrg = Get-IntersightFcpoolFcBlock -Organization $org

#Get the FcpoolFcBlock based on query Parameter
$FcpoolFcBlockByQueryParam = Get-IntersightFcpoolFcBlock -Filter Name eq FcpoolFcBlockName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .