#Get the SoftwarerepositoryAuthorization to delete
$SoftwarerepositoryAuthorization = Get-IntersightSoftwarerepositoryAuthorization -Name SoftwarerepositoryAuthorizationName
$SoftwarerepositoryAuthorization | Remove-IntersightSoftwarerepositoryAuthorization

#Remove the SoftwarerepositoryAuthorization by Moid.
Remove-IntersightSoftwarerepositoryAuthorization -Moid '<Replace with Moid>'
