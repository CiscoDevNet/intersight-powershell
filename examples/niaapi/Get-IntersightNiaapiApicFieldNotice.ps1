#Get the NiaapiApicFieldNotice by Name
$NiaapiApicFieldNoticeByName = Get-IntersightNiaapiApicFieldNotice -Name NiaapiApicFieldNoticeName

#Get the List of ServerProfiles
$NiaapiApicFieldNoticeList = Get-IntersightNiaapiApicFieldNotice

#Get the list of NiaapiApicFieldNotice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiApicFieldNoticeByOrg = Get-IntersightNiaapiApicFieldNotice -Organization $org

#Get the NiaapiApicFieldNotice based on query Parameter
$NiaapiApicFieldNoticeByQueryParam = Get-IntersightNiaapiApicFieldNotice -Filter Name eq NiaapiApicFieldNoticeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .