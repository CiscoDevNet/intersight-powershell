#Get the IaasDiagnosticMessages by Name
$IaasDiagnosticMessagesByName = Get-IntersightIaasDiagnosticMessages -Name IaasDiagnosticMessagesName

#Get the List of ServerProfiles
$IaasDiagnosticMessagesList = Get-IntersightIaasDiagnosticMessages

#Get the list of IaasDiagnosticMessages under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IaasDiagnosticMessagesByOrg = Get-IntersightIaasDiagnosticMessages -Organization $org

#Get the IaasDiagnosticMessages based on query Parameter
$IaasDiagnosticMessagesByQueryParam = Get-IntersightIaasDiagnosticMessages -Filter Name eq IaasDiagnosticMessagesName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .