   M S B A M L   `   `   `  ????K  GDevAssessmentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:DevAssessmentWPF.ViewModelDevAssessmentWPF.ViewModel  5      !    DevAssessmentWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >	ViewModel(clr-namespace:DevAssessmentWPF.ViewModel     5        ? Title$  
MainWindow??5   	   $	??600??6   $	??571??6)    ? 	Resources 5      4  .DevAssessmentWPF.ViewModel.MainWindowViewModel   VM   BooleanToVisibilityConverter  StatusArray ?? Type   Status  GenderArray   Gender??%  &	        &	      &	 &     &	 ?       5	   
   6(   ?? 5
   
   6'   ?? 5   
   "  6&   .s?5        $ active??6,     5      $ inactive??6,   5      ?? 5   
   "  6&   .s?5        $
 male??6,     5      $ female??6,   5      5      .??5      ? -   5         ?Name$ MainGrid??5      $??Center=?5   	   $
??Auto??6&    ? DataContext 5   	   ??  ?? Source# [   ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $??4* ?6   .+?5   
   ?? -   5        	 ??Name$	 StackPanelGetPost??5      
 ?? Orientation$
 
Horizontal=?5      $??Center=?5      $??0 10 0 0q?5       .+?5!      ?? -   5         ??Name$ 	ButtonGet??5!      $??20??5#      $	??120??5$      $??Get Employees??5%      ??5"      ?? *GetButtonClicked+5%      ?? 5&      -   5        $ 
ButtonPost??5&      $??10 0 0 0q?5(      $??20??5)      $	??120??5*      $??Register Employee??5+      $??Bottom=?5,      ??5'      ?? *ShowRegistrationForm+5,      5-      ? 5.   
   -   5        $ GridEmployeeDetails??5.      $??1??50      y?5/      ?? *
IsLoadData+ ?? 	Converter# [  51      ?? 52      $
??Auto ?6    ?? 53      $??* ?6    ?? 54      $??* ?6     ? ColumnDefinitions 56      ?? 57      $
??Auto ?6#   .+?59      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridEmployee??59         AutoGenerateColumns$ False??5<         AlternatingRowBackground
 ??İ?
???????$??2q?5?      
???????$??0 10 0 0q?5A         RowBackground
 ?????$
??Auto??5C      ??5:      ?? *	Employees+ ?? SelectedItem 5;      ?? *SelectedEmployee+   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      -   5        
ColumnName??,  &System.Windows.Controls.DataGridColumn   Header$
 Name??5F   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5G   %   ?? *Name+  5H      -   5        ColumnEmail??$ Email??5I   %    5J   %   ?? *Email+  5K      -	   5        ColumnGender??$ Gender??5L   %    5M   %   ?? *Gender+  5N      -
   5        ColumnStatus??$ Status??5O   %    5P   %   ?? *Status+5Z      ?? 5[      -   5        $	 StackPanelPatchDelete??5[      $??Center=?5\      $??0 10 0 0q?5]      $
 
Horizontal=?5^      $??1??5_      .+?5`      ?? -   5        $ ButtonUpdate??5`      $??20??5c      $	??120??5d      $??Update??5e      ??5a      ?? *UpdateButtonClicked+??5b      ?? *SelectedEmployee+5e      ?? 5f      -   5        $ ButtonDelete??5f      $??10 0 0 0q?5i      $??20??5j      $	??120??5k      $??Delete??5l      ??5g      ?? *DeleteButtonClicked+??5h      ?? *SelectedEmployee+5l      5m      ?? 5n      -   5         ??Name$ TextBlockResponse??5n      $??Center=?5p      $??20 8 0 0q?5q      $??2??5r      ??5o      ?? *ResponseMessage+5r      5s      ? 5v   
   -   5        $ GridCreateNewEmployee??5v      $??2??5x      y?5w      ?? *
IsShowForm+# [  5y      ?? 5z      $
??Auto ?6    ?? 5{      $
??Auto ?6    ?? 5|      $
??Auto ?6    ?? 5}      $
??Auto ?6    ?? 5~      $
??Auto ?6    ?? 5      $??5* ?6     5?      ?? 5?      $
??Auto ?6#   ?? 5?      $
??Auto ?6#   .+?5?      ?? -   5         ??Name$ LabelUserName??5?      $??Name:??5?      $??0 10 0 0q?5?      ?? 5?      -   5        $ LabelUserEmail??5?      $??Email:??5?      $??1??5?      ?? 5?      -   5        $ LabelGender??5?      $??Gender:??5?      $??2??5?      ?? 5?      -   5         ??Name$ TextBoxUserFirstName??5?      $??20??5?      $	??150??5?      $??1??5?      ??5?      ?? *Name+5?      ?? 5?      -   5        $ TextBoxUserEmail??5?      $??20??5?      $	??150??5?      $??1??5?      $??1??5?      ??5?      ?? *Email+5?      ?? 5?      -   5        $ TextBoxGender??5?      $??20??5?      $	??150??5?      $??2??5?      $??1??5?      ??5?      ?? *Gender+5?      ?? 5?      -   5        $ 	ButtonAdd??5?      $??20??5?      $	??100??5?      $
??POST??5?      $??Center=?5?      $??	20 10 0 0q?5?      $??4??5?      $??2??5?      ??5?      ?? *PostButtonClick+??5?      ?? *CreateEmployee+5?      ?? 5?      -   5        $ TextBlockMessage??5?      $??Center=?5?      $??20 8 0 0q?5?      $??5??5?      $??2??5?      ??5?      ?? *ShowPostMessage+5?      5?      5?      5?      