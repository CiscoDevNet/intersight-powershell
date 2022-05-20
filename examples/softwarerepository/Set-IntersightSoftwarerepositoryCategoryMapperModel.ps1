# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the SoftwarerepositoryCategoryMapperModel  to Update
$SoftwarerepositoryCategoryMapperModel = Get-IntersightSoftwarerepositoryCategoryMapperModel -Name SoftwarerepositoryCategoryMapperModelName

# Update the SoftwarerepositoryCategoryMapperModel
$category_mapper_model1 = $SoftwarerepositoryCategoryMapperModel | Set-IntersightSoftwarerepositoryCategoryMapperModel -Category 'adapter'