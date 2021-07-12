#Get the AssetSubscription by Name
$AssetSubscriptionByName = Get-IntersightAssetSubscription -Name AssetSubscriptionName

#Get the List of ServerProfiles
$AssetSubscriptionList = Get-IntersightAssetSubscription

#Get the list of AssetSubscription under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AssetSubscriptionByOrg = Get-IntersightAssetSubscription -Organization $org

#Get the AssetSubscription based on query Parameter
$AssetSubscriptionByQueryParam = Get-IntersightAssetSubscription -Filter Name eq AssetSubscriptionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .