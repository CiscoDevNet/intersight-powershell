#Get the AssetTarget by Name
$AssetTargetByName = Get-IntersightAssetTarget -Name AssetTargetName

#Get the List of ServerProfiles
$AssetTargetList = Get-IntersightAssetTarget

#Get the list of AssetTarget under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetTargetByOrg = Get-IntersightAssetTarget -Organization $org

#Get the AssetTarget based on query Parameter
$AssetTargetByQueryParam = Get-IntersightAssetTarget -Filter Name eq AssetTargetName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .