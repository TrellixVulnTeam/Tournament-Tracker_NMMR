   M S B A M L   `   `   `  ����N  JTournamentTrackerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TournamentTrackerUITournamentTrackerUI  5      $    TournamentTrackerUI.CreateTeam   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:TournamentTrackerUI     5        � Title$  
CreateTeam��5      $	��600��6   $	��700��6&   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��211* �6   �� 5      $
��239* �6    � RowDefinitions 5   
   �� 5      $	��181 �6   �� 5      $	��619 �6   .+�5   
   �� $��Create Team��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   $��20(�6l   $��37��6z   $	��118��6�   �� 5   
   $��Team Name: ��6   $
��Left=�6&   $��	27,52,0,0q�6A   $	��Top=�6T   $��30��6l   $	��102��6x   �� 5   
   -   5         ��Name$ teamName_textbx��5      $
��Left=�6+   $��
184,55,0,0q�6F   $��
enter name��6Z    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��165��6�   $��24��6�   $��2��6�   �� 5   
   -   5         ��Name$ selectTeamMember_dropdown��5      $
��Left=�67   $��
184,90,0,0q�6R   $	��Top=�6f   $	��165��6~   $��22��6�   $��2��6�   �� 5   
   -   5         ��Name$ addMember_Btn��5      $��
Add Member��6(   $
��Left=�6=   $��106,126,0,0q�6X   $	��Top=�6m   $��26��6�   $	��106��6�    J� RenderTransformOrigin$ 0.573,-1.316&�6�   6�   �� 5   
   $��Create New Member��6   $��10,33,10,285q�6.   $��1��6D   .��5      �� $��	30,0,18,0q�6   $	��263��6,   .+�5      �� $��
First Name��6   $	��106��6-   $
��Left=�69   �� 5      -   5        $ firstName_textbx��5      $��first��64   $
 Wrap=�6A   $	��176��6U   $
��Left=�6a   �� 5      $��	Last Name��6   $	��104��6,   $
��Left=�68   �� 5      -   5        $ lastName_textbx��5      $
��last��63   $
 Wrap=�6?   $	��176��6S   $
��Left=�6_   �� 5       $��E-mail��6   $	��104��6)   $
��Left=�65   �� 5!      -   5        $ email_textbx��5!      $��
you@me.com��60   $
 Wrap=�6B   $	��176��6V   $
��Left=�6b   �� 5"      $��	Cellphone��6   $	��104��6,   $
��Left=�68   �� 5#      -   5        $ cellphone_textbx��5#      $��867-5309��64   $
 Wrap=�6D   $	��176��6X   $
��Left=�6d   �� 5$      -   5        $ CreateMemberField��5$      $��Create Member:��64   $	��138��6M   $��10,10,10,10q�6Y   5&      5'      5(      �� 5)   
   -	   5         ��Name$ teamMember_ListBx��5)      $��42,33,42,285q�6-   $ 0.5,0.5&�6C   $��1��6c   $��1��6s   �� 5*   
   -
   5        $ createTeam_Btn��5*      $��Create Team��6)   $
��Left=�6?   $��218,353,0,0q�6Z   $	��Top=�6o   $��34��6�   $	��146��6�   $��1��6�   $��2��6�   �� 5+   
   -   5        $ removeSelected_Btn��5+      $
��Left=�6.   $��
394,79,0,0q�6I   $	��Top=�6]   $��46��6u   $��83��6�   $��1��6�   $��1��6�   .��5,      �� $ 0.735,-1&�6   Remove�� 6@   
Selected6U   5-      �� 5.   
   $��
27,84,96,0q�6   $��Select Team Member:��6(   $
��Wrap=�6C   $	��Top=�6W   $��28��6o   $��16(�6{   $��0��6�   50      51      