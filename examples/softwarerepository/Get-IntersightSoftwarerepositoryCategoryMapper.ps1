#Get the SoftwarerepositoryCategoryMapper by Name
$SoftwarerepositoryCategoryMapperByName = Get-IntersightSoftwarerepositoryCategoryMapper -Name SoftwarerepositoryCategoryMapperName

#Get the List of SoftwarerepositoryCategoryMapper
$SoftwarerepositoryCategoryMapperList = Get-IntersightSoftwarerepositoryCategoryMapper

#Get the list of SoftwarerepositoryCategoryMapper under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryCategoryMapperByOrg = Get-IntersightSoftwarerepositoryCategoryMapper -Organization $org

#Get the SoftwarerepositoryCategoryMapper based on query Parameter
$SoftwarerepositoryCategoryMapperByQueryParam = Get-IntersightSoftwarerepositoryCategoryMapper -Filter Name eq SoftwarerepositoryCategoryMapperName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .