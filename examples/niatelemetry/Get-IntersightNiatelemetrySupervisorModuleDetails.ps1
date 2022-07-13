#Get the NiatelemetrySupervisorModuleDetails by Name
$NiatelemetrySupervisorModuleDetailsByName = Get-IntersightNiatelemetrySupervisorModuleDetails -Name NiatelemetrySupervisorModuleDetailsName

#Get the List of ServerProfiles
$NiatelemetrySupervisorModuleDetailsList = Get-IntersightNiatelemetrySupervisorModuleDetails

#Get the list of NiatelemetrySupervisorModuleDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetrySupervisorModuleDetailsByOrg = Get-IntersightNiatelemetrySupervisorModuleDetails -Organization $org

#Get the NiatelemetrySupervisorModuleDetails based on query Parameter
$NiatelemetrySupervisorModuleDetailsByQueryParam = Get-IntersightNiatelemetrySupervisorModuleDetails -Filter Name eq NiatelemetrySupervisorModuleDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .