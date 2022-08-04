#Get the HyperflexWitnessConfiguration by Name
$HyperflexWitnessConfigurationByName = Get-IntersightHyperflexWitnessConfiguration -Name HyperflexWitnessConfigurationName

#Get the List of ServerProfiles
$HyperflexWitnessConfigurationList = Get-IntersightHyperflexWitnessConfiguration

#Get the list of HyperflexWitnessConfiguration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexWitnessConfigurationByOrg = Get-IntersightHyperflexWitnessConfiguration -Organization $org

#Get the HyperflexWitnessConfiguration based on query Parameter
$HyperflexWitnessConfigurationByQueryParam = Get-IntersightHyperflexWitnessConfiguration -Filter Name eq HyperflexWitnessConfigurationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .