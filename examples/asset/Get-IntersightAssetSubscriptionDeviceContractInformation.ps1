#Get the AssetSubscriptionDeviceContractInformation by Name
$AssetSubscriptionDeviceContractInformationByName = Get-IntersightAssetSubscriptionDeviceContractInformation -Name AssetSubscriptionDeviceContractInformationName

#Get the List of ServerProfiles
$AssetSubscriptionDeviceContractInformationList = Get-IntersightAssetSubscriptionDeviceContractInformation

#Get the list of AssetSubscriptionDeviceContractInformation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetSubscriptionDeviceContractInformationByOrg = Get-IntersightAssetSubscriptionDeviceContractInformation -Organization $org

#Get the AssetSubscriptionDeviceContractInformation based on query Parameter
$AssetSubscriptionDeviceContractInformationByQueryParam = Get-IntersightAssetSubscriptionDeviceContractInformation -Filter Name eq AssetSubscriptionDeviceContractInformationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .