#Get the NiatelemetryNiaFeatureUsage by Name
$NiatelemetryNiaFeatureUsageByName = Get-IntersightNiatelemetryNiaFeatureUsage -Name NiatelemetryNiaFeatureUsageName

#Get the List of ServerProfiles
$NiatelemetryNiaFeatureUsageList = Get-IntersightNiatelemetryNiaFeatureUsage

#Get the list of NiatelemetryNiaFeatureUsage under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNiaFeatureUsageByOrg = Get-IntersightNiatelemetryNiaFeatureUsage -Organization $org

#Get the NiatelemetryNiaFeatureUsage based on query Parameter
$NiatelemetryNiaFeatureUsageByQueryParam = Get-IntersightNiatelemetryNiaFeatureUsage -Filter Name eq NiatelemetryNiaFeatureUsageName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .