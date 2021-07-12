
#Get the OprsSyncTargetListMessage to delete
$OprsSyncTargetListMessage = Remove-IntersightOprsSyncTargetListMessage -Name OprsSyncTargetListMessageName
$OprsSyncTargetListMessage | Remove-IntersightOprsSyncTargetListMessage

#Remove the server profile by Moid.
Remove-IntersightOprsSyncTargetListMessage -Moid 123bc2222287wee
