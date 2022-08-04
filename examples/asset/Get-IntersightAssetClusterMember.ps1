#Get the AssetClusterMember by Name
$AssetClusterMemberByName = Get-IntersightAssetClusterMember -Name AssetClusterMemberName

#Get the List of ServerProfiles
$AssetClusterMemberList = Get-IntersightAssetClusterMember

#Get the list of AssetClusterMember under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetClusterMemberByOrg = Get-IntersightAssetClusterMember -Organization $org

#Get the AssetClusterMember based on query Parameter
$AssetClusterMemberByQueryParam = Get-IntersightAssetClusterMember -Filter Name eq AssetClusterMemberName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .