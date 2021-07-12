#Get the IaasUcsdManagedInfra by Name
$IaasUcsdManagedInfraByName = Get-IntersightIaasUcsdManagedInfra -Name IaasUcsdManagedInfraName

#Get the List of ServerProfiles
$IaasUcsdManagedInfraList = Get-IntersightIaasUcsdManagedInfra

#Get the list of IaasUcsdManagedInfra under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IaasUcsdManagedInfraByOrg = Get-IntersightIaasUcsdManagedInfra -Organization $org

#Get the IaasUcsdManagedInfra based on query Parameter
$IaasUcsdManagedInfraByQueryParam = Get-IntersightIaasUcsdManagedInfra -Filter Name eq IaasUcsdManagedInfraName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .