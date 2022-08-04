#Get the IaasUcsdInfo by Name
$IaasUcsdInfoByName = Get-IntersightIaasUcsdInfo -Name IaasUcsdInfoName

#Get the List of ServerProfiles
$IaasUcsdInfoList = Get-IntersightIaasUcsdInfo

#Get the list of IaasUcsdInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IaasUcsdInfoByOrg = Get-IntersightIaasUcsdInfo -Organization $org

#Get the IaasUcsdInfo based on query Parameter
$IaasUcsdInfoByQueryParam = Get-IntersightIaasUcsdInfo -Filter Name eq IaasUcsdInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .