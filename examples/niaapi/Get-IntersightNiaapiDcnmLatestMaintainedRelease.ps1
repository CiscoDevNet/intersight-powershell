#Get the NiaapiDcnmLatestMaintainedRelease by Name
$NiaapiDcnmLatestMaintainedReleaseByName = Get-IntersightNiaapiDcnmLatestMaintainedRelease -Name NiaapiDcnmLatestMaintainedReleaseName

#Get the List of ServerProfiles
$NiaapiDcnmLatestMaintainedReleaseList = Get-IntersightNiaapiDcnmLatestMaintainedRelease

#Get the list of NiaapiDcnmLatestMaintainedRelease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiDcnmLatestMaintainedReleaseByOrg = Get-IntersightNiaapiDcnmLatestMaintainedRelease -Organization $org

#Get the NiaapiDcnmLatestMaintainedRelease based on query Parameter
$NiaapiDcnmLatestMaintainedReleaseByQueryParam = Get-IntersightNiaapiDcnmLatestMaintainedRelease -Filter Name eq NiaapiDcnmLatestMaintainedReleaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .