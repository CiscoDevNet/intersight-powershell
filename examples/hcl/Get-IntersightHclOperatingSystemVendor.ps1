#Get the HclOperatingSystemVendor by Name
$HclOperatingSystemVendorByName = Get-IntersightHclOperatingSystemVendor -Name HclOperatingSystemVendorName

#Get the List of ServerProfiles
$HclOperatingSystemVendorList = Get-IntersightHclOperatingSystemVendor

#Get the list of HclOperatingSystemVendor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HclOperatingSystemVendorByOrg = Get-IntersightHclOperatingSystemVendor -Organization $org

#Get the HclOperatingSystemVendor based on query Parameter
$HclOperatingSystemVendorByQueryParam = Get-IntersightHclOperatingSystemVendor -Filter Name eq HclOperatingSystemVendorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .