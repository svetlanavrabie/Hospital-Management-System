   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.RecherchePatient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	     � Title$  RecherchePatient��5   	   $	��450��6"   $	��920��6/   ���	#FF8CD5E0.��5	      � .+�5   
   �� $8��2LE NORTHERN LIGHTS HOSPITAL - Recherche de patiens��6   $
��Left=�6M   $��
142,10,0,0q�6h   $	��Top=�6|   $��20(�6�   $��Showcard Gothic)�6�   ���	#FF0B1B66$	��574��6�   �� 5   
   $
��Left=�6   $��53��6+   $��	43,10,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m    J� RenderTransformOrigin$ 1.264,0.535&�6�   �� 5   
   $*��$Entrer le NSS du patient recherché:��6   $
��Left=�6>   $��31��6Y   $��	32,94,0,0q�6e   $	��Top=�6x   $	��285��6�   ���	#FF640A0A$
��Bold"�6�   $��16(�6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
listegride��5      $
��Left=�6'      AutoGenerateColumns .  $	��122��6^   $��
10,156,0,0q�6k   $	��Top=�6   $	��882��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	IdPatient��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	IdPatient+6C     5      $	 NSS��6=    6%   �� *NSS+6=     5      $ DateNaissance��6G    6%   �� *DateNaissance+6G     5      $	 Nom��6=    6%   �� *Nom+6=     5      $ Prenom��6@    6%   �� *Prenom+6@     5      $ TypePatient��6E    6%   �� *TypePatient+6E     5      $ Adresse��6A    6%   �� *	Adresse+6A     5      $ Ville��6?    6%   �� *Ville+6?     5      $ Province��6B    6%   �� *
Province+6B     5      $ 
CodePostal��6D    6%   �� *
CodePostal+6D     5      $ 	Telephone��6C    6%   �� *	Telephone+6C     5      $ 
 IdMedicin��6C    6%   �� *	IdMedicin+6C     5      $ IdCompagnie��6E    6%   �� *IdCompagnie+6E     5      $ 	RefParent��6C    6%   �� *	RefParent+6C   5!      �� 5"   
   -   5         ��Name$ txtNSS��5"      $
��Left=�6"   $��25��6=   $��339,100,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��132��6�   �� 5#   
   -   5        	 ��Name$	 btnRech��5#      $��
Rechercher��6"   $
��Left=�67   $��25��6R   $��530,100,0,0q�6^   $	��Top=�6s   $	��122��6�   6�   �� 5$   
   -   5        $��Quitter��5$      $
��Left=�6#   $��34��6>   $��780,316,0,0q�6J   $	��Top=�6_   $��90��6w   6�   �� 5%   
   $
��Left=�6   $��72��6+   $��
824,10,0,0q�67   $	��Top=�6K   $��68��6c   $��image/add_patient.png��6n   $ 0.367,0.091&�6�   5'      5(      