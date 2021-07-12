#Get the NiaapiApicHweol by Name
$NiaapiApicHweolByName = Get-IntersightNiaapiApicHweol -Name NiaapiApicHweolName

#Get the List of ServerProfiles
$NiaapiApicHweolList = Get-IntersightNiaapiApicHweol

#Get the list of NiaapiApicHweol under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiApicHweolByOrg = Get-IntersightNiaapiApicHweol -Organization $org

#Get the NiaapiApicHweol based on query Parameter
$NiaapiApicHweolByQueryParam = Get-IntersightNiaapiApicHweol -Filter Name eq NiaapiApicHweolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .