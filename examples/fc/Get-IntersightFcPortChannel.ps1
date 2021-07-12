#Get the FcPortChannel by Name
$FcPortChannelByName = Get-IntersightFcPortChannel -Name FcPortChannelName

#Get the List of ServerProfiles
$FcPortChannelList = Get-IntersightFcPortChannel

#Get the list of FcPortChannel under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FcPortChannelByOrg = Get-IntersightFcPortChannel -Organization $org

#Get the FcPortChannel based on query Parameter
$FcPortChannelByQueryParam = Get-IntersightFcPortChannel -Filter Name eq FcPortChannelName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .