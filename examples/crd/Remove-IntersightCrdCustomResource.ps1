
#Get the CrdCustomResource to delete
$CrdCustomResource = Remove-IntersightCrdCustomResource -Name CrdCustomResourceName
$CrdCustomResource | Remove-IntersightCrdCustomResource

#Remove the server profile by Moid.
Remove-IntersightCrdCustomResource -Moid 123bc2222287wee
