#Get the NiaapiDcnmSweol by Name
$NiaapiDcnmSweolByName = Get-IntersightNiaapiDcnmSweol -Name NiaapiDcnmSweolName

#Get the List of ServerProfiles
$NiaapiDcnmSweolList = Get-IntersightNiaapiDcnmSweol

#Get the list of NiaapiDcnmSweol under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiaapiDcnmSweolByOrg = Get-IntersightNiaapiDcnmSweol -Organization $org

#Get the NiaapiDcnmSweol based on query Parameter
$NiaapiDcnmSweolByQueryParam = Get-IntersightNiaapiDcnmSweol -Filter Name eq NiaapiDcnmSweolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .