#Get the ForecastInstance by Name
$ForecastInstanceByName = Get-IntersightForecastInstance -Name ForecastInstanceName

#Get the List of ServerProfiles
$ForecastInstanceList = Get-IntersightForecastInstance

#Get the list of ForecastInstance under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ForecastInstanceByOrg = Get-IntersightForecastInstance -Organization $org

#Get the ForecastInstance based on query Parameter
$ForecastInstanceByQueryParam = Get-IntersightForecastInstance -Filter Name eq ForecastInstanceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .