#Get the NiaapiDcnmReleaseRecommend by Name
$NiaapiDcnmReleaseRecommendByName = Get-IntersightNiaapiDcnmReleaseRecommend -Name NiaapiDcnmReleaseRecommendName

#Get the List of ServerProfiles
$NiaapiDcnmReleaseRecommendList = Get-IntersightNiaapiDcnmReleaseRecommend

#Get the list of NiaapiDcnmReleaseRecommend under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiDcnmReleaseRecommendByOrg = Get-IntersightNiaapiDcnmReleaseRecommend -Organization $org

#Get the NiaapiDcnmReleaseRecommend based on query Parameter
$NiaapiDcnmReleaseRecommendByQueryParam = Get-IntersightNiaapiDcnmReleaseRecommend -Filter Name eq NiaapiDcnmReleaseRecommendName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .