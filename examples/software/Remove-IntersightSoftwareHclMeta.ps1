
#Get the SoftwareHclMeta to delete
$SoftwareHclMeta = Get-IntersightSoftwareHclMeta -Name SoftwareHclMetaName
$SoftwareHclMeta | Remove-IntersightSoftwareHclMeta

#Remove the SoftwareHclMeta by Moid.
Remove-IntersightSoftwareHclMeta -Moid '<Replace with Moid>'
