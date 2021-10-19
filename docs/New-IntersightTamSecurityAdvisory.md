---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightTamSecurityAdvisory

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightTamSecurityAdvisory [-Actions< System.Collections.Generic.List`1[TamAction]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdvisoryId< string>][-ApiDataSources< System.Collections.Generic.List`1[TamApiDataSource]>][-BaseScore< float>][-CveIds< System.Collections.Generic.List`1[string]>][-DatePublished< DateTime>][-DateUpdated< DateTime>][-Description< string>][-EnvironmentalScore< float>][-ExternalUrl< string>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Recommendation< string>][-Severity< TamSeverity>][-State< TamSecurityAdvisory.StateEnum>][-Status< TamSecurityAdvisory.StatusEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TemporalScore< float>][-Version< string>][-Workaround< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;TamSecurityAdvisory&apos; resource.

## PARAMETERS

### -Actions


Note :- Use Initialize-IntersightTamAction to create the object of complex type TamAction

```yaml
Type: System.Collections.Generic.List`1[TamAction]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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

### -AdvisoryId
Cisco generated identifier for the published security advisory.

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

### -ApiDataSources


Note :- Use Initialize-IntersightTamApiDataSource to create the object of complex type TamApiDataSource

```yaml
Type: System.Collections.Generic.List`1[TamApiDataSource]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BaseScore
CVSS version 3 base score for the security Advisory.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CveIds


```yaml
Type: System.Collections.Generic.List`1[string]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DatePublished
Date when the security advisory was first published by Cisco.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DateUpdated
Date when the security advisory was last updated by Cisco.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Brief description of the advisory details.

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

### -EnvironmentalScore
CVSS version 3 environmental score for the security Advisory.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ExternalUrl
A link to an external URL describing security Advisory in more details.

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

### -Moid
The unique identifier of this Managed Object instance.

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

### -Name
A user defined name for the Intersight Advisory.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Recommendation
Recommended action to resolve the security advisory.

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

### -Severity
Severity level of the Intersight Advisory.

Note :- Use Initialize-IntersightTamSeverity to create the object of complex type TamSeverity

```yaml
Type: TamSeverity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -State
Current state of the advisory.\n* `ready` - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created.\n* `evaluating` - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation.

```yaml
Type: TamSecurityAdvisory.StateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
Cisco assigned status of the published advisory based on whether the investigation is complete or on-going.\n* `interim` - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available.\n* `final` - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability.

```yaml
Type: TamSecurityAdvisory.StatusEnum
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

### -TemporalScore
CVSS version 3 temporal score for the security Advisory.

```yaml
Type: float
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
Cisco assigned advisory version after latest revision.

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

### -Workaround
Workarounds available for the advisory.

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
PS C:\> New-IntersightTamSecurityAdvisory
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightTamSecurityAdvisory](./Remove-IntersightTamSecurityAdvisory.md)

[Set-IntersightTamSecurityAdvisory](./Set-IntersightTamSecurityAdvisory.md)

[Get-IntersightTamSecurityAdvisory](./Get-IntersightTamSecurityAdvisory.md)

[Initialize-IntersightTamAction](./Initialize-IntersightTamAction.md)

[Initialize-IntersightTamApiDataSource](./Initialize-IntersightTamApiDataSource.md)

[Initialize-IntersightTamSeverity](./Initialize-IntersightTamSeverity.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
