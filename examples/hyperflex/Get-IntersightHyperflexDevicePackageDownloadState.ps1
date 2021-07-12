#Get the HyperflexDevicePackageDownloadState by Name
$HyperflexDevicePackageDownloadStateByName = Get-IntersightHyperflexDevicePackageDownloadState -Name HyperflexDevicePackageDownloadStateName

#Get the List of ServerProfiles
$HyperflexDevicePackageDownloadStateList = Get-IntersightHyperflexDevicePackageDownloadState

#Get the list of HyperflexDevicePackageDownloadState under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexDevicePackageDownloadStateByOrg = Get-IntersightHyperflexDevicePackageDownloadState -Organization $org

#Get the HyperflexDevicePackageDownloadState based on query Parameter
$HyperflexDevicePackageDownloadStateByQueryParam = Get-IntersightHyperflexDevicePackageDownloadState -Filter Name eq HyperflexDevicePackageDownloadStateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .