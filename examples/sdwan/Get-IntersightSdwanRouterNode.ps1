#Get the SdwanRouterNode by Name
$SdwanRouterNodeByName = Get-IntersightSdwanRouterNode -Name SdwanRouterNodeName

#Get the List of ServerProfiles
$SdwanRouterNodeList = Get-IntersightSdwanRouterNode

#Get the list of SdwanRouterNode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SdwanRouterNodeByOrg = Get-IntersightSdwanRouterNode -Organization $org

#Get the SdwanRouterNode based on query Parameter
$SdwanRouterNodeByQueryParam = Get-IntersightSdwanRouterNode -Filter Name eq SdwanRouterNodeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .