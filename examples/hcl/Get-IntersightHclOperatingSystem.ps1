#Get the HclOperatingSystem by Name
$HclOperatingSystemByName = Get-IntersightHclOperatingSystem -Name HclOperatingSystemName

#Get the List of ServerProfiles
$HclOperatingSystemList = Get-IntersightHclOperatingSystem

#Get the list of HclOperatingSystem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HclOperatingSystemByOrg = Get-IntersightHclOperatingSystem -Organization $org

#Get the HclOperatingSystem based on query Parameter
$HclOperatingSystemByQueryParam = Get-IntersightHclOperatingSystem -Filter Name eq HclOperatingSystemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .