#Get the OprsDeployment by Name
$OprsDeploymentByName = Get-IntersightOprsDeployment -Name OprsDeploymentName

#Get the List of ServerProfiles
$OprsDeploymentList = Get-IntersightOprsDeployment

#Get the list of OprsDeployment under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OprsDeploymentByOrg = Get-IntersightOprsDeployment -Organization $org

#Get the OprsDeployment based on query Parameter
$OprsDeploymentByQueryParam = Get-IntersightOprsDeployment -Filter Name eq OprsDeploymentName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .