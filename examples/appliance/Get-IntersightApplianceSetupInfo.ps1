#Get the ApplianceSetupInfo by Name
$ApplianceSetupInfoByName = Get-IntersightApplianceSetupInfo -Name ApplianceSetupInfoName

#Get the List of ServerProfiles
$ApplianceSetupInfoList = Get-IntersightApplianceSetupInfo

#Get the list of ApplianceSetupInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceSetupInfoByOrg = Get-IntersightApplianceSetupInfo -Organization $org

#Get the ApplianceSetupInfo based on query Parameter
$ApplianceSetupInfoByQueryParam = Get-IntersightApplianceSetupInfo -Filter Name eq ApplianceSetupInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .