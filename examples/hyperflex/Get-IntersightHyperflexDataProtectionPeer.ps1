#Get the HyperflexDataProtectionPeer by Name
$HyperflexDataProtectionPeerByName = Get-IntersightHyperflexDataProtectionPeer -Name HyperflexDataProtectionPeerName

#Get the List of ServerProfiles
$HyperflexDataProtectionPeerList = Get-IntersightHyperflexDataProtectionPeer

#Get the list of HyperflexDataProtectionPeer under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexDataProtectionPeerByOrg = Get-IntersightHyperflexDataProtectionPeer -Organization $org

#Get the HyperflexDataProtectionPeer based on query Parameter
$HyperflexDataProtectionPeerByQueryParam = Get-IntersightHyperflexDataProtectionPeer -Filter Name eq HyperflexDataProtectionPeerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .