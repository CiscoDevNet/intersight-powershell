#Get the NiaapiApicSweol by Name
$NiaapiApicSweolByName = Get-IntersightNiaapiApicSweol -Name NiaapiApicSweolName

#Get the List of ServerProfiles
$NiaapiApicSweolList = Get-IntersightNiaapiApicSweol

#Get the list of NiaapiApicSweol under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiApicSweolByOrg = Get-IntersightNiaapiApicSweol -Organization $org

#Get the NiaapiApicSweol based on query Parameter
$NiaapiApicSweolByQueryParam = Get-IntersightNiaapiApicSweol -Filter Name eq NiaapiApicSweolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .