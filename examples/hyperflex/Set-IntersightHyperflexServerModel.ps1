
#Get the HyperflexServerModel to Update
$HyperflexServerModel = Get-IntersightHyperflexServerModel -Name HyperflexServerModelName
$HyperflexServerModel | Set-IntersightHyperflexServerModel -Description 'Updated description'
