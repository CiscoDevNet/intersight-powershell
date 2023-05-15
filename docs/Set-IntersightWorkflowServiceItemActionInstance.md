---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowServiceItemActionInstance

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowServiceItemActionInstance [-Action< WorkflowServiceItemActionInstance.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Idp< IamIdpRelationship>][-IdpReference< IamIdpReferenceRelationship>][-Input< object>][[-Moid]< string>][-ServiceItemActionDefinition< WorkflowServiceItemActionDefinitionRelationship>][-ServiceItemInstance< WorkflowServiceItemInstanceRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-User< IamUserRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;WorkflowServiceItemActionInstance&apos; resource.

## PARAMETERS

### -Action
Name of the action that needs to be performed on the service item instance.\n* `None` - No action is set, this is the default value for action field.\n* `Validate` - Validate the action instance inputs and run the validation workflows.\n* `Start` - Start a new execution of the action instance.\n* `Rerun` - Rerun the service item action instance from the beginning.\n* `Retry` - Retry the workflow that has failed from the failure point.\n* `Cancel` - Cancel the core workflow that is in running or waiting state. This action can be used when the workflows are stuck and not progressing.\n* `Stop` - Stop the action instance which is in progress and didn&apos;t complete successfully. Use this action to clear the state and then delete the action instance. A completed action cannot be stopped.

```yaml
Type: WorkflowServiceItemActionInstance.ActionEnum
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

### -Idp
A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamIdpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IdpReference
A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamIdpReferenceRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Input
Inputs for a service item action and the format is specified by input definition of the service item action definition.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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

### -ServiceItemActionDefinition
A reference to a workflowServiceItemActionDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowServiceItemActionDefinitionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServiceItemInstance
A reference to a workflowServiceItemInstance resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowServiceItemInstanceRelationship
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

### -User
A reference to a iamUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamUserRelationship
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
PS C:\> Set-IntersightWorkflowServiceItemActionInstance
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightWorkflowServiceItemActionInstance](./Get-IntersightWorkflowServiceItemActionInstance.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightServiceitemMessage](./Initialize-IntersightServiceitemMessage.md)

[Initialize-IntersightServiceitemSelectionCriteriaInput](./Initialize-IntersightServiceitemSelectionCriteriaInput.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[New-IntersightWorkflowServiceItemActionInstance](./New-IntersightWorkflowServiceItemActionInstance.md)

[Remove-IntersightWorkflowServiceItemActionInstance](./Remove-IntersightWorkflowServiceItemActionInstance.md)
