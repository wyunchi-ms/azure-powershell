### Example 1: Create a Windows Virtual Desktop ApplicationGroup by name
```powershell
New-AzWvdApplicationGroup -ResourceGroupName ResourceGroupName `
                            -Name ApplicationGroupName `
                            -Location 'eastus' `
                            -FriendlyName 'Friendly Name' `
                            -Description 'Description' `
                            -HostPoolArmPath '/subscriptions/SubscriptionId/resourcegroups/ResourceGroupName/providers/Microsoft.DesktopVirtualization/hostPools/HostPoolName' `
                            -ApplicationGroupType 'RemoteApp' `
                            -ShowInFeed
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ApplicationGroupName Microsoft.DesktopVirtualization/applicationgroups
```

This command creates a Windows Virtual Desktop ApplicationGroup in a Resource Group.

### Example 2: Create a Windows Virtual Desktop ApplicationGroup by name
```powershell
New-AzWvdApplicationGroup -ResourceGroupName ResourceGroupName `
                            -Name ApplicationGroupName `
                            -Location 'eastus' `
                            -FriendlyName 'Friendly Name' `
                            -Description 'Description' `
                            -HostPoolArmPath '/subscriptions/SubscriptionId/resourcegroups/ResourceGroupName/providers/Microsoft.DesktopVirtualization/hostPools/HostPoolName' `
                            -ApplicationGroupType 'Desktop' `
                            -ShowInFeed
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ApplicationGroupName Microsoft.DesktopVirtualization/applicationgroups
```

This command creates a Windows Virtual Desktop ApplicationGroup in a Resource Group.

