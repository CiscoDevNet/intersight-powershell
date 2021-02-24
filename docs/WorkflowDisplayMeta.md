# WorkflowDisplayMeta
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.DisplayMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.DisplayMeta"]
**InventorySelector** | **Boolean** | Inventory selector specified for primitive data property should be used in Intersight User Interface. | [optional] [default to $true]
**WidgetType** | **String** | Specify the widget type for data display. * &#x60;None&#x60; - Display none of the widget types. * &#x60;Radio&#x60; - Display the widget as a radio button. * &#x60;Dropdown&#x60; - Display the widget as a dropdown. * &#x60;GridSelector&#x60; - Display the widget as a selector. * &#x60;DrawerSelector&#x60; - Display the widget as a selector. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$WorkflowDisplayMeta = Initialize-IntersightWorkflowDisplayMeta  -ClassId null `
 -ObjectType null `
 -InventorySelector null `
 -WidgetType null
```

- Convert the resource to JSON
```powershell
$WorkflowDisplayMeta | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

