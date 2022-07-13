#Get the SoftwarerepositoryCategoryMapperModel by Name
$SoftwarerepositoryCategoryMapperModelByName = Get-IntersightSoftwarerepositoryCategoryMapperModel -Name SoftwarerepositoryCategoryMapperModelName

#Get the List of SoftwarerepositoryCategoryMapperModel
$SoftwarerepositoryCategoryMapperModelList = Get-IntersightSoftwarerepositoryCategoryMapperModel

#Get the list of SoftwarerepositoryCategoryMapperModel under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwarerepositoryCategoryMapperModelByOrg = Get-IntersightSoftwarerepositoryCategoryMapperModel -Organization $org

#Get the SoftwarerepositoryCategoryMapperModel based on query Parameter
$SoftwarerepositoryCategoryMapperModelByQueryParam = Get-IntersightSoftwarerepositoryCategoryMapperModel -Filter Name eq SoftwarerepositoryCategoryMapperModelName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .