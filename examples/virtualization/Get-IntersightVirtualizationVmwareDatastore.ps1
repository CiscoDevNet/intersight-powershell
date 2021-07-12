#Get the VirtualizationVmwareDatastore by Name
$VirtualizationVmwareDatastoreByName = Get-IntersightVirtualizationVmwareDatastore -Name VirtualizationVmwareDatastoreName

#Get the List of ServerProfiles
$VirtualizationVmwareDatastoreList = Get-IntersightVirtualizationVmwareDatastore

#Get the list of VirtualizationVmwareDatastore under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareDatastoreByOrg = Get-IntersightVirtualizationVmwareDatastore -Organization $org

#Get the VirtualizationVmwareDatastore based on query Parameter
$VirtualizationVmwareDatastoreByQueryParam = Get-IntersightVirtualizationVmwareDatastore -Filter Name eq VirtualizationVmwareDatastoreName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .