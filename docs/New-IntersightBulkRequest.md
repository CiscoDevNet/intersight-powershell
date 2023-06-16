---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightBulkRequest

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightBulkRequest [-ActionOnError< BulkRequest.ActionOnErrorEnum>][-Actions< System.Collections.Generic.List`1[BulkRequest.ActionsEnum]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Moid< string>][-Organization< OrganizationOrganizationRelationship>][-Requests< System.Collections.Generic.List`1[BulkSubRequest]>][-SkipDuplicates< bool>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Uri< string>][-Verb< BulkRequest.VerbEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;BulkRequest&apos; resource.

## PARAMETERS

### -ActionOnError
The action to be taken when an error occurs during processing of the request.\n* `Stop` - Stop the processing of the request after the first error.\n* `Proceed` - Proceed with the processing of the request even when an error occurs.

```yaml
Type: BulkRequest.ActionOnErrorEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Actions


```yaml
Type: System.Collections.Generic.List`1[BulkRequest.ActionsEnum]
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

### -Requests


Note :- Use Initialize-IntersightBulkSubRequest to create the object of complex type BulkSubRequest

```yaml
Type: System.Collections.Generic.List`1[BulkSubRequest]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SkipDuplicates
Skip the already present objects.

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

### -Uri
The URI on which this bulk action is to be performed.\nThe value will be used when there is no override in the SubRequest.

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

### -Verb
The type of operation to be performed.\nOne of - Post (Create), Patch (Update) or Delete (Remove).\nThe value will be used when there is no override in the SubRequest.\n* `POST` - Used to create a REST resource.\n* `PATCH` - Used to update a REST resource.\n* `DELETE` - Used to delete a REST resource.

```yaml
Type: BulkRequest.VerbEnum
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
PS C:\> New-IntersightBulkRequest
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightBulkRequest](./Get-IntersightBulkRequest.md)

[Initialize-IntersightBulkApiResult](./Initialize-IntersightBulkApiResult.md)

[Initialize-IntersightBulkHttpHeader](./Initialize-IntersightBulkHttpHeader.md)

[Initialize-IntersightBulkRequest.ActionsEnum](./Initialize-IntersightBulkRequest.ActionsEnum.md)

[Initialize-IntersightBulkSubRequest](./Initialize-IntersightBulkSubRequest.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
