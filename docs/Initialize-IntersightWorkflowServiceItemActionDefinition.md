---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowServiceItemActionDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowServiceItemActionDefinition [-ActionProperties< Model.WorkflowServiceItemActionProperties>][-ActionType< WorkflowServiceItemActionDefinition.ActionTypeEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AllowedInstanceStates< System.Collections.Generic.List`1[WorkflowServiceItemActionDefinition.AllowedInstanceStatesEnum]>][-AssociatedRoles< System.Collections.Generic.List`1[Model.IamRoleRelationship]>][-AttributeParameters< object>][-ClassId< WorkflowServiceItemActionDefinition.ClassIdEnum>][-CoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]>][-Description< string>][-InputDefinition< System.Collections.Generic.List`1[Model.WorkflowBaseDataType]>][-Label< string>][-Moid< string>][-Name< string>][-ObjectType< WorkflowServiceItemActionDefinition.ObjectTypeEnum>][-Periodicity< long>][-PostCoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]>][-PreCoreWorkflows< System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]>][-RestrictOnPrivateAppliance< bool>][-ServiceItemDefinition< Model.WorkflowServiceItemDefinitionRelationship>][-StopWorkflows< System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-ValidationWorkflows< System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -ActionProperties
Action properties for the service item.

Note :- Use Initialize-IntersightWorkflowServiceItemActionProperties to create the object of complex type WorkflowServiceItemActionProperties

```yaml
Type: Model.WorkflowServiceItemActionProperties
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ActionType
Type of actionDefinition which decides on how to trigger the action.\n* `External` - External actions definition can be triggered by enduser to perform actions on the service item. Once action is completed successfully (eg. create/deploy), user cannot re-trigger that action again.\n* `Internal` - Internal action definition is used to trigger periodic actions on the service item instance.\n* `Repetitive` - Repetitive action definition is an external action that can be triggered by enduser to perform repetitive actions (eg. Edit/Update/Perform health check) on the created service item.

```yaml
Type: WorkflowServiceItemActionDefinition.ActionTypeEnum
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

### -AllowedInstanceStates


```yaml
Type: System.Collections.Generic.List`1[WorkflowServiceItemActionDefinition.AllowedInstanceStatesEnum]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AssociatedRoles
An array of relationships to iamRole resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[Model.IamRoleRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AttributeParameters
The mappings from workflows in the action definition to the service item attribute definition. Any output from core or post-core workflow can be mapped to service item attribute definition. The attribute can be referred using the name of the workflow definition and the attribute name in the following format &apos;${&lt;ServiceItemActionWorkflowDefinition.Name&gt;.output.&lt;outputName&gt;&apos;.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkflowServiceItemActionDefinition.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CoreWorkflows


Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
The description for this action which provides information on what are the pre-requisites to use this action on the service item and what features are supported by this action.

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

### -InputDefinition


Note :- Use Initialize-IntersightWorkflowBaseDataType to create the object of complex type WorkflowBaseDataType

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowBaseDataType]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Label
A user friendly short name to identify the action. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_).

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
The name for this action definition. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:) or an underscore (_). Name of the action must be unique within a service item definition.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowServiceItemActionDefinition.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Periodicity
Value in seconds to specify the periodicity of the workflows. A zero value indicate the workflow will not execute periodically. A non-zero value indicate, the workflow will be executed periodically with this periodicity.

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

### -PostCoreWorkflows


Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PreCoreWorkflows


Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RestrictOnPrivateAppliance
The flag to indicate that action is restricted on a Private Virtual Appliance.

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

### -ServiceItemDefinition
A reference to a workflowServiceItemDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.WorkflowServiceItemDefinitionRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StopWorkflows


Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]
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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ValidationWorkflows


Note :- Use Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition to create the object of complex type WorkflowServiceItemActionWorkflowDefinition

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowServiceItemActionWorkflowDefinition]
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
PS C:\> Initialize-IntersightWorkflowServiceItemActionDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-IntersightWorkflowServiceItemActionProperties](./Initialize-IntersightWorkflowServiceItemActionProperties.md)

[Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition](./Initialize-IntersightWorkflowServiceItemActionWorkflowDefinition.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
