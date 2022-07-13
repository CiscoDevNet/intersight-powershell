#Get the MemoryArray by Name
$MemoryArrayByName = Get-IntersightMemoryArray -Name MemoryArrayName

#Get the List of ServerProfiles
$MemoryArrayList = Get-IntersightMemoryArray

#Get the list of MemoryArray under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryArrayByOrg = Get-IntersightMemoryArray -Organization $org

#Get the MemoryArray based on query Parameter
$MemoryArrayByQueryParam = Get-IntersightMemoryArray -Filter Name eq MemoryArrayName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .