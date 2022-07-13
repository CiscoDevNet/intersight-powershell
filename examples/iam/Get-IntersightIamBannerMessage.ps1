#Get the IamBannerMessage by Name
$IamBannerMessageByName = Get-IntersightIamBannerMessage -Name IamBannerMessageName

#Get the List of ServerProfiles
$IamBannerMessageList = Get-IntersightIamBannerMessage

#Get the list of IamBannerMessage under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamBannerMessageByOrg = Get-IntersightIamBannerMessage -Organization $org

#Get the IamBannerMessage based on query Parameter
$IamBannerMessageByQueryParam = Get-IntersightIamBannerMessage -Filter Name eq IamBannerMessageName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .