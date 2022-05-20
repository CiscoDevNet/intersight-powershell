
#Get the HyperflexNodeProfile to Update
$HyperflexNodeProfile = Get-IntersightHyperflexNodeProfile -Name HyperflexNodeProfileName
$HyperflexNodeProfile | Set-IntersightHyperflexNodeProfile -Description 'Updated description'
