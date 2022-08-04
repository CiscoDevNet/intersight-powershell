#Get the NiaapiDcnmCcoPost by Name
$NiaapiDcnmCcoPostByName = Get-IntersightNiaapiDcnmCcoPost -Name NiaapiDcnmCcoPostName

#Get the List of ServerProfiles
$NiaapiDcnmCcoPostList = Get-IntersightNiaapiDcnmCcoPost

#Get the list of NiaapiDcnmCcoPost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiDcnmCcoPostByOrg = Get-IntersightNiaapiDcnmCcoPost -Organization $org

#Get the NiaapiDcnmCcoPost based on query Parameter
$NiaapiDcnmCcoPostByQueryParam = Get-IntersightNiaapiDcnmCcoPost -Filter Name eq NiaapiDcnmCcoPostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .