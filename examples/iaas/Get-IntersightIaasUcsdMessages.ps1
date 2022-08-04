#Get the IaasUcsdMessages by Name
$IaasUcsdMessagesByName = Get-IntersightIaasUcsdMessages -Name IaasUcsdMessagesName

#Get the List of ServerProfiles
$IaasUcsdMessagesList = Get-IntersightIaasUcsdMessages

#Get the list of IaasUcsdMessages under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IaasUcsdMessagesByOrg = Get-IntersightIaasUcsdMessages -Organization $org

#Get the IaasUcsdMessages based on query Parameter
$IaasUcsdMessagesByQueryParam = Get-IntersightIaasUcsdMessages -Filter Name eq IaasUcsdMessagesName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .