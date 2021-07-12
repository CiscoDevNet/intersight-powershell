#Get the NiaapiApicReleaseRecommend by Name
$NiaapiApicReleaseRecommendByName = Get-IntersightNiaapiApicReleaseRecommend -Name NiaapiApicReleaseRecommendName

#Get the List of ServerProfiles
$NiaapiApicReleaseRecommendList = Get-IntersightNiaapiApicReleaseRecommend

#Get the list of NiaapiApicReleaseRecommend under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiApicReleaseRecommendByOrg = Get-IntersightNiaapiApicReleaseRecommend -Organization $org

#Get the NiaapiApicReleaseRecommend based on query Parameter
$NiaapiApicReleaseRecommendByQueryParam = Get-IntersightNiaapiApicReleaseRecommend -Filter Name eq NiaapiApicReleaseRecommendName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .