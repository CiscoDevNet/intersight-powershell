# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwarerepositoryCategoryMapperModel  to Update
$SoftwarerepositoryCategoryMapperModel = Get-IntersightSoftwarerepositoryCategoryMapperModel -Name SoftwarerepositoryCategoryMapperModelName

# Update the SoftwarerepositoryCategoryMapperModel
$category_mapper_model1 = $SoftwarerepositoryCategoryMapperModel | Set-IntersightSoftwarerepositoryCategoryMapperModel -Category 'adapter'