---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowServiceItemActionProperties

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowServiceItemActionProperties [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowServiceItemActionProperties.ClassIdEnum>][-ObjectType< WorkflowServiceItemActionProperties.ObjectTypeEnum>][-OperationType< WorkflowServiceItemActionProperties.OperationTypeEnum>][-Properties< object>][-StopOnFailure< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkflowServiceItemActionProperties.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowServiceItemActionProperties.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OperationType
Type of action operation to be executed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item.\n* `Migration` - This represents the migration action, used to migrate service item instance from one service item definition version to another service item definition version. All valid service items can have up to one operation type marked as Migration. Once a migration action is running on a service item instance, no further operations are allowed on that service item instance during the migration process.

```yaml
Type: WorkflowServiceItemActionProperties.OperationTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Properties
The properties of the action. The actual structure of properties can vary based on the operationType.

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

### -StopOnFailure
When true, the action on the service item will be stopped when it reaches a failure by either calling the configured stop workflow or by calling the rollback workflow. By default value is set to true.

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
PS C:\> Initialize-IntersightWorkflowServiceItemActionProperties
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
