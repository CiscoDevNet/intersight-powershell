#Get the HclDriverImage by Name
$HclDriverImageByName = Get-IntersightHclDriverImage -Name HclDriverImageName

#Get the List of ServerProfiles
$HclDriverImageList = Get-IntersightHclDriverImage

#Get the list of HclDriverImage under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HclDriverImageByOrg = Get-IntersightHclDriverImage -Organization $org

#Get the HclDriverImage based on query Parameter
$HclDriverImageByQueryParam = Get-IntersightHclDriverImage -Filter Name eq HclDriverImageName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .