
#Get the KubernetesNode to delete
$KubernetesNode = Get-IntersightKubernetesNode -Name KubernetesNodeName
$KubernetesNode | Remove-IntersightKubernetesNode

#Remove the server profile by Moid.
Remove-IntersightKubernetesNode -Moid '<Replace with Moid>'
