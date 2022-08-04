
# Get the AccessPolicy to delete
$AccessPolicy = Get-IntersightAccessPolicy -Name AccessPolicyName

$AccessPolicy | Remove-IntersightAccessPolicy

# Remove the AccessPolicy by Moid.
Remove-IntersightAccessPolicy -Moid '<Replace with Moid>'
