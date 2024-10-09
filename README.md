# How-to-show-hamburger-icon-in-all-pages-in-.NET-MAUI-NavigationDrawer
How to show hamburger icon in all pages in .NET MAUI NavigationDrawer

**XAML**
```
 <Grid RowDefinitions="80,*">
    <Grid BackgroundColor="#6750A4" ColumnDefinitions="Auto,*,Auto" Grid.Row="0" ColumnSpacing="10" Padding="10,0">
        <Image Grid.Column="0"
             HeightRequest="30"
             WidthRequest="30"
             HorizontalOptions="Start"
             Source="hamburgericon.png"             
             BackgroundColor="#6750A4">
            <Image.GestureRecognizers>
                <TapGestureRecognizer Tapped="Handle_Clicked"/>
            </Image.GestureRecognizers>
        </Image>
    </Grid>

    <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" Grid.Row="1">
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings DrawerHeaderHeight="177" DrawerWidth="260" DrawerHeight="{OnPlatform WinUI=400}" ContentBackground="#F7F2FB" DrawerFooterHeight="0">
                <navigationdrawer:DrawerSettings.DrawerHeaderView>
                    <Grid RowDefinitions="*,Auto,Auto" Padding="25,25,25,20">
                        <Image Source="user.png" VerticalOptions="Center" WidthRequest="72" HeightRequest="72"/>
                        <Label Grid.Row="1" Text="Leslie Alexander"  VerticalTextAlignment="Center" HorizontalTextAlignment="Center" TextColor="#1C1B1F" FontAttributes="Bold" FontSize="16" WidthRequest="154"  HorizontalOptions="Center"/>
                        <Label Grid.Row="2" Text="UX Designer"  VerticalTextAlignment="Center" HorizontalTextAlignment="Center" TextColor="#1C1B1F" FontSize="12" WidthRequest="148" HeightRequest="24" HorizontalOptions="Center"/>
                    </Grid>
                </navigationdrawer:DrawerSettings.DrawerHeaderView>

                <navigationdrawer:DrawerSettings.DrawerContentView>
                    <ListView x:Name="listView"
                  ItemSelected="listView_ItemSelected">
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid>
                                        <Label Text="{Binding}"          
                                               FontSize="16"
                                               Margin="10,7,0,0"
                                               TextColor="Black"
                                               HorizontalOptions="Start"
                                               VerticalOptions="Center">
                                        </Label>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </navigationdrawer:DrawerSettings.DrawerContentView>
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>
</Grid>
```
**C#**
```
private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e) 
 {
     if (e.SelectedItem.ToString() == "Home")
         navigationDrawer.ContentView = new HomePage().Content;
     else if (e.SelectedItem.ToString() == "Profile")
         navigationDrawer.ContentView = new ProfilePage().Content;
     navigationDrawer.ToggleDrawer();
 }
```
**Create a new page**

**XAML**

```
<VerticalStackLayout>
    <Label 
        Text="Welcome to HomePage!"
        VerticalOptions="Center" 
        HorizontalOptions="Center" />
</VerticalStackLayout>
```
