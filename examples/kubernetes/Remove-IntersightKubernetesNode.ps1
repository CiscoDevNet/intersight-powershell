
#Get the KubernetesNode to delete
$KubernetesNode = Remove-IntersightKubernetesNode -Name KubernetesNodeName
$KubernetesNode | Remove-IntersightKubernetesNode

#Remove the server profile by Moid.
Remove-IntersightKubernetesNode -Moid 123bc2222287wee
