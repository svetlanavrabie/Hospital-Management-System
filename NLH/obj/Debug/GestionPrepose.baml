   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.GestionPrepose   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   -   5          � Title$  GestionPrepose��5   	   $	��470��6    $	��700��6-   ���	#FF8CD5E0.��5	      � .+�5
   
   �� $7��1LE NORTHERN LIGHTS HOSPITAL - Gestion de Preposes��6   $
��Left=�6L   $��	94,10,0,0q�6g   $	��Top=�6z   $��20(�6�   $��Showcard Gothic)�6�   ���	#FF0B1B666�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dateprep��5      $
��Left=�6%      AutoGenerateColumns .  $	��127��6\   $��
365,66,0,0q�6i   $	��Top=�6}   $	��290��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	IdPrepose��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	IdPrepose+6C     5      $	 Nom��6=    6%   �� *Nom+6=     5      $ Prenom��6@    6%   �� *Prenom+6@     5      $ 
Specialite��6D    6%   �� *
Specialite+6D   5      �� 5   
   -   5         ��Name$ tbxNom��5      $
��Left=�6"   $��23��6=   $��378,277,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ 	tbxPrenom��5      $
��Left=�6%   $��23��6@   $��378,325,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ tbxspes��5      $
��Left=�6#   $��23��6>   $��378,376,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��ID Prepose:��6   $
��Left=�6&   $��378,205,0,0q�6A   $	��Top=�6V    J� RenderTransformOrigin$ 0.571,1.077&�6n   �� 5   
   $
��Nom:��6   $
��Left=�6   $��378,254,0,0q�6:   $	��Top=�6O   �� 5   
   $��Prenom:��6   $
��Left=�6"   $��378,299,0,0q�6=   $	��Top=�6R   �� 5   
   $��
Specialite��6   $
��Left=�6%   $��378,353,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        	 ��Name$	 btnMod��5      $��Modifier��6!   $
��Left=�64   $��32��6O   $��538,271,0,0q�6[   $	��Top=�6p   $	��117��6�   6�   �� 5   
   -   5        $	 btnSup��5      $��	Suprimmer��6!   $
��Left=�65   $��32��6P   $��538,316,0,0q�6\   $	��Top=�6q   $	��117��6�   $ 0.394,0.625&�6�   6�   �� 5   
   -   5        $	 
btnQuitter��5      $��Quitter��6%   $
��Left=�67   $��32��6R   $��538,367,0,0q�6^   $	��Top=�6s   $	��117��6�   $ -0.273,1.125&�6�   �� 5    
   $
��Left=�6   $	��331��6+   $��	26,68,0,0q�68   $	��Top=�6K   $	��313��6c   $��image/prepose.jpg��6o   �� 5!   
   $
��Left=�6   $��53��6+   $��	43,10,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m   $ 1.264,0.535&�6�   �� 5"   
   -	   5        
 ��Name$
 comb1��5"      $
��Left=�6"   $��23��6=   $��378,236,0,0q�6I   $	��Top=�6^   $	��120��6v   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� DisplayMemberPath$ 	IdPrepose��6�   ��6�   �� 6�   5$      5%      