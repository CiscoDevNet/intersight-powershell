#Get the AssetDeviceContractInformation by Name
$AssetDeviceContractInformationByName = Get-IntersightAssetDeviceContractInformation -Name AssetDeviceContractInformationName

#Get the List of ServerProfiles
$AssetDeviceContractInformationList = Get-IntersightAssetDeviceContractInformation

#Get the list of AssetDeviceContractInformation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AssetDeviceContractInformationByOrg = Get-IntersightAssetDeviceContractInformation -Organization $org

#Get the AssetDeviceContractInformation based on query Parameter
$AssetDeviceContractInformationByQueryParam = Get-IntersightAssetDeviceContractInformation -Filter Name eq AssetDeviceContractInformationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .