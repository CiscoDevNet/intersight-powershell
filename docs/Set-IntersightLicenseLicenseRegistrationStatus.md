---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightLicenseLicenseRegistrationStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightLicenseLicenseRegistrationStatus [-AccountCreationState< bool>][-AccountLicenseData< LicenseAccountLicenseDataRelationship>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-LicenseRegistrationState< LicenseLicenseRegistrationStatus.LicenseRegistrationStateEnum>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TrialRegistrationComplete< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;LicenseLicenseRegistrationStatus&apos; resource.

## PARAMETERS

### -AccountCreationState
Stores information on whether account has gone through the registration wizard. True if has not.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AccountLicenseData
A reference to a licenseAccountLicenseData resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseAccountLicenseDataRelationship
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

### -LicenseRegistrationState
Stores information on the current flow of license registration.\n* `RegistrationNotStarted` - The license registration state to chose between trial and registration.\n* `RegistrationStarted` - The license registration state during set up flow.\n* `RegistrationComplete` - The license registration state after completion.

```yaml
Type: LicenseLicenseRegistrationStatus.LicenseRegistrationStateEnum
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

### -TrialRegistrationComplete
Stores information on whether trial flow has been completed. True if trial registration finish.

```yaml
Type: bool
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
PS C:\> Set-IntersightLicenseLicenseRegistrationStatus
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightLicenseLicenseRegistrationStatus](./Get-IntersightLicenseLicenseRegistrationStatus.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
