#Get the NiaapiApicLatestMaintainedRelease by Name
$NiaapiApicLatestMaintainedReleaseByName = Get-IntersightNiaapiApicLatestMaintainedRelease -Name NiaapiApicLatestMaintainedReleaseName

#Get the List of ServerProfiles
$NiaapiApicLatestMaintainedReleaseList = Get-IntersightNiaapiApicLatestMaintainedRelease

#Get the list of NiaapiApicLatestMaintainedRelease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiApicLatestMaintainedReleaseByOrg = Get-IntersightNiaapiApicLatestMaintainedRelease -Organization $org

#Get the NiaapiApicLatestMaintainedRelease based on query Parameter
$NiaapiApicLatestMaintainedReleaseByQueryParam = Get-IntersightNiaapiApicLatestMaintainedRelease -Filter Name eq NiaapiApicLatestMaintainedReleaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .