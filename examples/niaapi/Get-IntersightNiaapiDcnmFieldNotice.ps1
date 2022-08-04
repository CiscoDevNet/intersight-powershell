#Get the NiaapiDcnmFieldNotice by Name
$NiaapiDcnmFieldNoticeByName = Get-IntersightNiaapiDcnmFieldNotice -Name NiaapiDcnmFieldNoticeName

#Get the List of ServerProfiles
$NiaapiDcnmFieldNoticeList = Get-IntersightNiaapiDcnmFieldNotice

#Get the list of NiaapiDcnmFieldNotice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiDcnmFieldNoticeByOrg = Get-IntersightNiaapiDcnmFieldNotice -Organization $org

#Get the NiaapiDcnmFieldNotice based on query Parameter
$NiaapiDcnmFieldNoticeByQueryParam = Get-IntersightNiaapiDcnmFieldNotice -Filter Name eq NiaapiDcnmFieldNoticeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .