#Get the AssetDeploymentDevice by Name
$AssetDeploymentDeviceByName = Get-IntersightAssetDeploymentDevice -Name AssetDeploymentDeviceName

#Get the List of ServerProfiles
$AssetDeploymentDeviceList = Get-IntersightAssetDeploymentDevice

#Get the list of AssetDeploymentDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetDeploymentDeviceByOrg = Get-IntersightAssetDeploymentDevice -Organization $org

#Get the AssetDeploymentDevice based on query Parameter
$AssetDeploymentDeviceByQueryParam = Get-IntersightAssetDeploymentDevice -Filter Name eq AssetDeploymentDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .