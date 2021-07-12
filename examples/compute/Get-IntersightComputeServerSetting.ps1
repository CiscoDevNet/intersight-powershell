#Get the ComputeServerSetting by Name
$ComputeServerSettingByName = Get-IntersightComputeServerSetting -Name ComputeServerSettingName

#Get the List of ServerProfiles
$ComputeServerSettingList = Get-IntersightComputeServerSetting

#Get the list of ComputeServerSetting under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ComputeServerSettingByOrg = Get-IntersightComputeServerSetting -Organization $org

#Get the ComputeServerSetting based on query Parameter
$ComputeServerSettingByQueryParam = Get-IntersightComputeServerSetting -Filter Name eq ComputeServerSettingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .