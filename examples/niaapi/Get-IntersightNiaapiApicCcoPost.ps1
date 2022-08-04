#Get the NiaapiApicCcoPost by Name
$NiaapiApicCcoPostByName = Get-IntersightNiaapiApicCcoPost -Name NiaapiApicCcoPostName

#Get the List of ServerProfiles
$NiaapiApicCcoPostList = Get-IntersightNiaapiApicCcoPost

#Get the list of NiaapiApicCcoPost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiApicCcoPostByOrg = Get-IntersightNiaapiApicCcoPost -Organization $org

#Get the NiaapiApicCcoPost based on query Parameter
$NiaapiApicCcoPostByQueryParam = Get-IntersightNiaapiApicCcoPost -Filter Name eq NiaapiApicCcoPostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .