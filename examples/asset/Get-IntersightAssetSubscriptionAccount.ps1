#Get the AssetSubscriptionAccount by Name
$AssetSubscriptionAccountByName = Get-IntersightAssetSubscriptionAccount -Name AssetSubscriptionAccountName

#Get the List of ServerProfiles
$AssetSubscriptionAccountList = Get-IntersightAssetSubscriptionAccount

#Get the list of AssetSubscriptionAccount under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetSubscriptionAccountByOrg = Get-IntersightAssetSubscriptionAccount -Organization $org

#Get the AssetSubscriptionAccount based on query Parameter
$AssetSubscriptionAccountByQueryParam = Get-IntersightAssetSubscriptionAccount -Filter Name eq AssetSubscriptionAccountName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .