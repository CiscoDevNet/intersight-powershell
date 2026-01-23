---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightServerDiagnosticStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightServerDiagnosticStatus [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Checksum< ConnectorFileChecksum>][-DiagnosticsType< ServerDiagnosticStatus.DiagnosticsTypeEnum>][-DownloadError< string>][-DownloadProgress< long>][-DownloadRetries< long>][[-Moid]< string>][-Server< ComputePhysicalRelationship>][-Sha256checksum< byte>][-Tags< System.Collections.Generic.List`1[MoTag]>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;ServerDiagnosticStatus&apos; resource.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Checksum
The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file.

Note :- Use Initialize-IntersightConnectorFileChecksum to create the object of complex type ConnectorFileChecksum

```yaml
Type: ConnectorFileChecksum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DiagnosticsType
Type of diagnostics to be performed on the server hardware components.\n* `Quick` - Perform fast and limited diagnostics on server hardware components.\n* `Comprehensive` - Perform slow and extensive diagnostics on server hardware components.

```yaml
Type: ServerDiagnosticStatus.DiagnosticsTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DownloadError
Any error encountered. Set to empty when download is in progress or completed.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DownloadProgress
The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible, a value of -1 is sent.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DownloadRetries
The number of retries the plugin attempted before succeeding or failing the download.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Server
A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ComputePhysicalRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sha256checksum
The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file.

```yaml
Type: byte
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightServerDiagnosticStatus
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightServerDiagnosticStatus](./Get-IntersightServerDiagnosticStatus.md)

[Initialize-IntersightConnectorFileChecksum](./Initialize-IntersightConnectorFileChecksum.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightServerDiagnosticResult](./Initialize-IntersightServerDiagnosticResult.md)

[New-IntersightServerDiagnosticStatus](./New-IntersightServerDiagnosticStatus.md)

[Remove-IntersightServerDiagnosticStatus](./Remove-IntersightServerDiagnosticStatus.md)
