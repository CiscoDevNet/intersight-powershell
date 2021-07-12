#Get the SoftwarerepositoryCachedImage by Name
$SoftwarerepositoryCachedImageByName = Get-IntersightSoftwarerepositoryCachedImage -Name SoftwarerepositoryCachedImageName

#Get the List of ServerProfiles
$SoftwarerepositoryCachedImageList = Get-IntersightSoftwarerepositoryCachedImage

#Get the list of SoftwarerepositoryCachedImage under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryCachedImageByOrg = Get-IntersightSoftwarerepositoryCachedImage -Organization $org

#Get the SoftwarerepositoryCachedImage based on query Parameter
$SoftwarerepositoryCachedImageByQueryParam = Get-IntersightSoftwarerepositoryCachedImage -Filter Name eq SoftwarerepositoryCachedImageName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .