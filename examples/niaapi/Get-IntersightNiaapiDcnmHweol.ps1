#Get the NiaapiDcnmHweol by Name
$NiaapiDcnmHweolByName = Get-IntersightNiaapiDcnmHweol -Name NiaapiDcnmHweolName

#Get the List of ServerProfiles
$NiaapiDcnmHweolList = Get-IntersightNiaapiDcnmHweol

#Get the list of NiaapiDcnmHweol under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiDcnmHweolByOrg = Get-IntersightNiaapiDcnmHweol -Organization $org

#Get the NiaapiDcnmHweol based on query Parameter
$NiaapiDcnmHweolByQueryParam = Get-IntersightNiaapiDcnmHweol -Filter Name eq NiaapiDcnmHweolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .