
#Get the FaultInstance to Update
$FaultInstance = Get-IntersightFaultInstance -Moid <moid>
$FaultInstance | Set-IntersightFaultInstance -Description "Update description"