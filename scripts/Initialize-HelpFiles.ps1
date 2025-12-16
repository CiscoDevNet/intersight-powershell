$ModuleDir = $PSScriptRoot

# Get the module name from the directory name or manifest file
$ModuleName = (Split-Path -Path $ModuleDir -Leaf)
$ZippedHelpFile = Join-Path -Path $ModuleDir -ChildPath "$ModuleName.dll-Help.xml.zip"
$ExtractedHelpFile = Join-Path -Path $ModuleDir -ChildPath "$ModuleName.dll-Help.xml"

try {
    # Check if the zipped help file exists in the module directory
    if (Test-Path -Path $ZippedHelpFile -PathType Leaf) {
        Write-Verbose "Found zipped help file in module directory: $ZippedHelpFile"
        
        # Only extract if the XML file doesn't already exist
        if (-not (Test-Path -Path $ExtractedHelpFile -PathType Leaf)) {
            Write-Verbose "Extracting help file from: $ZippedHelpFile"
            
            # Use Expand-Archive to extract the ZIP file
            Expand-Archive -Path $ZippedHelpFile -DestinationPath $ModuleDir -ErrorAction Stop -Force 
            Write-Verbose "Successfully extracted help file to: $ExtractedHelpFile"
        }
        else {
            Write-Verbose "Help file already exists: $ExtractedHelpFile"
        }
    }
}
catch {
    Write-Verbose "Error initializing help files: $($_.Exception.Message)"
}