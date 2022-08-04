$filtered_models1 = Initialize-IntersightSoftwarerepositoryConstraintmodels -Name 'softwarerepository_constraint_models1' -MinVersion '12.1(5)E2'

$softwarerepository_category_support_constraint = New-IntersightSoftwarerepositoryCategorySupportConstraint -FilteredModels $filtered_models1 -Name 'softwarerepository_category_support_constraint1' -ParseFromImageName 1