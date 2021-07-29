
$moduleDir =  Join-Path -path $PSScriptRoot -ChildPath "Intersight.PowerShell"
$solutionPath = Join-Path -Path $PSScriptRoot -ChildPath "src\Intersight.PowerShell.sln"
dotnet build $solutionPath -o $moduleDir -c Release

#Check for whether build success or failure

if ($LASTEXITCODE -ne 0){
    Write-Host "Build failed, PLease fix the code and re-run."
}

#Generate the Moudle manifest file 

$manifestParam = @{
    Path = Join-Path -Path $moduleDir  -ChildPath "Intersight.PowerShell.psd1"  
    RootModule = "Intersight.PowerShell.dll"
    Guid = "41ce1a70-9c4b-489f-a153-12fe49b7fe62"
    Author = "Cisco Systems"
    CompanyName = "Cisco Systems"
    ModuleVersion = "1.0.9.4375"
    Copyright = "(c) 2021 Cisco Systems, Inc. All rights reserved."
    LicenseUri = "https://www.apache.org/licenses/LICENSE-2.0.txt"
    ProjectUri = "https://github.com/CiscoDevNet/intersight-powershell"
    CompatiblePSEditions = "Core"
    Tag = @('PSEdition_Core','Windows','Linux','MacOSX','Intersight','IntersightCmdlets')
    RequireLicenseAcceptance = $true
    PowerShellVersion = "7.1"
    Description = "Intersight Powershell module provides the cmdlets to manage, analyze, and automate the IT infrastructure in Intersight."
    ReleaseNotes = "Intersight.PowerShell - Version 1.0.9.4375

Features:
Intersight.PowerShell module provides,
 - Cmdlets for Create, Read, Update and Delete of managed objects in Cisco Intersight.
 - Initialize Cmdlet to create object locally.
 - New, Set and Remove Cmdlets to Create, Update and Delete objects from Cisco Intersight.
 - Pipeline support. 
 - Help content with examples.



Examples:- 
https://github.com/CiscoDevNet/intersight-powershell/tree/master/examples

Intersight Help Center:
https://www.intersight.com/help
"
}

$manifestResult = New-ModuleManifest @manifestParam

if($manifestResult){
    Write-Host "Module manifest created successfully." -ForegroundColor green
}

if (Test-Path -Path $moduleDir -PathType Container){
    $externalHelpFilePath =  Join-Path -Path $PSScriptRoot -ChildPath "externalHelp\Intersight.PowerShell.dll-help.xml"
    if (Test-Path -Path $externalHelpFilePath ){
        Copy-Item -Path $externalHelpFilePath -Destination $moduleDir
    }

}
else{
    Write-Host "Module directory $moduleDir does not exist, cannot copy external help file."
}
