#Get the FcPhysicalPort by Name
$FcPhysicalPortByName = Get-IntersightFcPhysicalPort -Name FcPhysicalPortName

#Get the List of ServerProfiles
$FcPhysicalPortList = Get-IntersightFcPhysicalPort

#Get the list of FcPhysicalPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FcPhysicalPortByOrg = Get-IntersightFcPhysicalPort -Organization $org

#Get the FcPhysicalPort based on query Parameter
$FcPhysicalPortByQueryParam = Get-IntersightFcPhysicalPort -Filter Name eq FcPhysicalPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .