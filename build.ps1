Param(
    [Parameter(Mandatory = $false)]
    [ValidateSet("Debug","Release")]
    [string]$BuildConfiguration = "Release"
)
$moduleDir =  Join-Path -path $PSScriptRoot -ChildPath "Intersight.PowerShell"
$solutionPath = Join-Path -Path $PSScriptRoot -ChildPath "src\Intersight.PowerShell.sln"
Write-host "Build the Intersight.PowerShell module."
try
{
    dotnet build $solutionPath -o $moduleDir -c $BuildConfiguration
}
catch{
    throw $_.Exception
    Exit 1
}
#Check for whether build success or failure

if ($LASTEXITCODE -ne 0){
    Write-Host "Build failed, PLease fix the code and re-run."
    Exit $LASTEXITCODE
}


# Import the dll and get the list of cmdlet available in the module
Import-Module -Name $moduleDir\Intersight.PowerShell.dll
$commandList = Get-Command -Module Intersight.PowerShell
Remove-module -Name Intersight.PowerShell

Write-Host "Generate the Moudle manifest file." 

$manifestParam = @{
    Path = Join-Path -Path $moduleDir  -ChildPath "Intersight.PowerShell.psd1"  
    RootModule = "Intersight.PowerShell.dll"
    Guid = "41ce1a70-9c4b-489f-a153-12fe49b7fe62"
    Author = "Cisco Systems"
    CompanyName = "Cisco Systems"
    ModuleVersion = "1.0.9.5208"
    Copyright = "(c) 2021 Cisco Systems, Inc. All rights reserved."
    LicenseUri = "https://www.apache.org/licenses/LICENSE-2.0.txt"
    ProjectUri = "https://github.com/CiscoDevNet/intersight-powershell"
    CompatiblePSEditions = "Core"
    Tag = @('PSEdition_Core','Windows','Linux','MacOSX','Intersight','IntersightCmdlets')
    PowerShellVersion = "7.1"
    CmdletsToExport = $commandList
    Description = "Intersight Powershell module provides the cmdlets to manage, analyze, and automate the IT infrastructure in Intersight."
    ReleaseNotes = "Intersight.PowerShell - Version 1.0.9.5208

Changelog:-
https://github.com/CiscoDevNet/intersight-powershell/blob/master/CHANGELOG.md

GettingStarted:- 
https://github.com/CiscoDevNet/intersight-powershell/blob/master/GettingStarted.md


Examples:- 
https://github.com/CiscoDevNet/intersight-powershell/tree/master/examples

Intersight Help Center:
https://www.intersight.com/help
"
}

$manifestResult = New-ModuleManifest @manifestParam
Write-Host "Module manifest created successfully." -ForegroundColor green

Write-Host "Copy module help file to $moduleDir"
if (Test-Path -Path $moduleDir -PathType Container){
    $externalHelpFilePath =  Join-Path -Path $PSScriptRoot -ChildPath "externalHelp\Intersight.PowerShell.dll-help.xml"
    if (Test-Path -Path $externalHelpFilePath ){
        Copy-Item -Path $externalHelpFilePath -Destination $moduleDir
        Write-Host "Successfully copied the help file to $moduleDir."
    }

}
else{
    Write-Host "Module directory $moduleDir does not exist, cannot copy external help file."
}
Write-Host "Intersight.PowerShell module build completed."