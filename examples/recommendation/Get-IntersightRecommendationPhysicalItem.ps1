#Get the RecommendationPhysicalItem by Name
$RecommendationPhysicalItemByName = Get-IntersightRecommendationPhysicalItem -Name RecommendationPhysicalItemName

#Get the List of ServerProfiles
$RecommendationPhysicalItemList = Get-IntersightRecommendationPhysicalItem

#Get the list of RecommendationPhysicalItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecommendationPhysicalItemByOrg = Get-IntersightRecommendationPhysicalItem -Organization $org

#Get the RecommendationPhysicalItem based on query Parameter
$RecommendationPhysicalItemByQueryParam = Get-IntersightRecommendationPhysicalItem -Filter Name eq RecommendationPhysicalItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .