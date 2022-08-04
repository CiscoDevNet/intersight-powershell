
#Get the KubernetesTrustedRegistriesPolicy to delete
$KubernetesTrustedRegistriesPolicy = Get-IntersightKubernetesTrustedRegistriesPolicy -Name KubernetesTrustedRegistriesPolicyName
$KubernetesTrustedRegistriesPolicy | Remove-IntersightKubernetesTrustedRegistriesPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesTrustedRegistriesPolicy -Moid '<Replace with Moid>'
