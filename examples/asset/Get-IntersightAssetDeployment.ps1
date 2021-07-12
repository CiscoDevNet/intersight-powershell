#Get the AssetDeployment by Name
$AssetDeploymentByName = Get-IntersightAssetDeployment -Name AssetDeploymentName

#Get the List of ServerProfiles
$AssetDeploymentList = Get-IntersightAssetDeployment

#Get the list of AssetDeployment under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AssetDeploymentByOrg = Get-IntersightAssetDeployment -Organization $org

#Get the AssetDeployment based on query Parameter
$AssetDeploymentByQueryParam = Get-IntersightAssetDeployment -Filter Name eq AssetDeploymentName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .