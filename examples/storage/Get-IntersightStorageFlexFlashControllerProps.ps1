#Get the StorageFlexFlashControllerProps by Name
$StorageFlexFlashControllerPropsByName = Get-IntersightStorageFlexFlashControllerProps -Name StorageFlexFlashControllerPropsName

#Get the List of ServerProfiles
$StorageFlexFlashControllerPropsList = Get-IntersightStorageFlexFlashControllerProps

#Get the list of StorageFlexFlashControllerProps under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageFlexFlashControllerPropsByOrg = Get-IntersightStorageFlexFlashControllerProps -Organization $org

#Get the StorageFlexFlashControllerProps based on query Parameter
$StorageFlexFlashControllerPropsByQueryParam = Get-IntersightStorageFlexFlashControllerProps -Filter Name eq StorageFlexFlashControllerPropsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .