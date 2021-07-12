#Get the SdwanProfile by Name
$SdwanProfileByName = Get-IntersightSdwanProfile -Name SdwanProfileName

#Get the List of ServerProfiles
$SdwanProfileList = Get-IntersightSdwanProfile

#Get the list of SdwanProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SdwanProfileByOrg = Get-IntersightSdwanProfile -Organization $org

#Get the SdwanProfile based on query Parameter
$SdwanProfileByQueryParam = Get-IntersightSdwanProfile -Filter Name eq SdwanProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .