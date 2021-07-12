#Get the KvmVmConsole by Name
$KvmVmConsoleByName = Get-IntersightKvmVmConsole -Name KvmVmConsoleName

#Get the List of ServerProfiles
$KvmVmConsoleList = Get-IntersightKvmVmConsole

#Get the list of KvmVmConsole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KvmVmConsoleByOrg = Get-IntersightKvmVmConsole -Organization $org

#Get the KvmVmConsole based on query Parameter
$KvmVmConsoleByQueryParam = Get-IntersightKvmVmConsole -Filter Name eq KvmVmConsoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .