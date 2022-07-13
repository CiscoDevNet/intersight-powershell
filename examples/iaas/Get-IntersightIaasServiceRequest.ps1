#Get the IaasServiceRequest by Name
$IaasServiceRequestByName = Get-IntersightIaasServiceRequest -Name IaasServiceRequestName

#Get the List of ServerProfiles
$IaasServiceRequestList = Get-IntersightIaasServiceRequest

#Get the list of IaasServiceRequest under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IaasServiceRequestByOrg = Get-IntersightIaasServiceRequest -Organization $org

#Get the IaasServiceRequest based on query Parameter
$IaasServiceRequestByQueryParam = Get-IntersightIaasServiceRequest -Filter Name eq IaasServiceRequestName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .