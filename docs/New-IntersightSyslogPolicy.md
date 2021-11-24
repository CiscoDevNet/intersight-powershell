---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightSyslogPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightSyslogPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-LocalClients< System.Collections.Generic.List`1[SyslogLocalClientBase]>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]>][-RemoteClients< System.Collections.Generic.List`1[SyslogRemoteClientBase]>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;SyslogPolicy&apos; resource.

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

### -Description
Description of the policy.

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

### -LocalClients


Note :- Use Initialize-IntersightSyslogLocalClientBase to create the object of complex type SyslogLocalClientBase
It also accepts the of object(s) of type SyslogLocalFileLoggingClient, use the respective Initialize cmdlet to create the object.
Cmdlet(s) :
Initialize-IntersightSyslogLocalFileLoggingClient

```yaml
Type: System.Collections.Generic.List`1[SyslogLocalClientBase]
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
Name of the concrete policy.

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

### -Profiles
An array of relationships to policyAbstractConfigProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteClients


Note :- Use Initialize-IntersightSyslogRemoteClientBase to create the object of complex type SyslogRemoteClientBase
It also accepts the of object(s) of type SyslogRemoteLoggingClient, use the respective Initialize cmdlet to create the object.
Cmdlet(s) :
Initialize-IntersightSyslogRemoteLoggingClient

```yaml
Type: System.Collections.Generic.List`1[SyslogRemoteClientBase]
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
PS C:\> New-IntersightSyslogPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightSyslogPolicy](./Get-IntersightSyslogPolicy.md)

[Remove-IntersightSyslogPolicy](./Remove-IntersightSyslogPolicy.md)

[Set-IntersightSyslogPolicy](./Set-IntersightSyslogPolicy.md)

[Initialize-IntersightSyslogLocalClientBase](./Initialize-IntersightSyslogLocalClientBase.md)

[Initialize-IntersightSyslogRemoteClientBase](./Initialize-IntersightSyslogRemoteClientBase.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
