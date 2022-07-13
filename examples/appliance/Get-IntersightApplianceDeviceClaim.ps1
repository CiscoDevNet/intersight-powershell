#Get the ApplianceDeviceClaim by Name
$ApplianceDeviceClaimByName = Get-IntersightApplianceDeviceClaim -Name ApplianceDeviceClaimName

#Get the List of ServerProfiles
$ApplianceDeviceClaimList = Get-IntersightApplianceDeviceClaim

#Get the list of ApplianceDeviceClaim under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceDeviceClaimByOrg = Get-IntersightApplianceDeviceClaim -Organization $org

#Get the ApplianceDeviceClaim based on query Parameter
$ApplianceDeviceClaimByQueryParam = Get-IntersightApplianceDeviceClaim -Filter Name eq ApplianceDeviceClaimName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .