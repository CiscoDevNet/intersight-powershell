$server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'

$image1 = Get-IntersightSoftwarerepositoryOperatingsystemfile -Moid '<Replace with Moid>'

$osdu_image1 = Get-IntersightFirmwareServerconfigurationutilitydistributable -Moid '<Replace with Moid>'

$answers1 = Initialize-IntersightOsAnswers -AnswerFile 'answer_file' -NrSource 'File'

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$os1 = New-IntersightOsInstall -Server $server1 -Image $image1 -OsduImage $osdu_image1 -Answers $answers1 -Organization $organization1 -Name 'InstallTemplatee165' -Description 'Install Template 5' -InstallMethod 'vMedia'