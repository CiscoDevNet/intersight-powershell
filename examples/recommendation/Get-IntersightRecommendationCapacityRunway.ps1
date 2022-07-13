#Get the RecommendationCapacityRunway by Name
$RecommendationCapacityRunwayByName = Get-IntersightRecommendationCapacityRunway -Name RecommendationCapacityRunwayName

#Get the List of ServerProfiles
$RecommendationCapacityRunwayList = Get-IntersightRecommendationCapacityRunway

#Get the list of RecommendationCapacityRunway under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecommendationCapacityRunwayByOrg = Get-IntersightRecommendationCapacityRunway -Organization $org

#Get the RecommendationCapacityRunway based on query Parameter
$RecommendationCapacityRunwayByQueryParam = Get-IntersightRecommendationCapacityRunway -Filter Name eq RecommendationCapacityRunwayName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .