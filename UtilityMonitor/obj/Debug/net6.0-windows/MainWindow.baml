   M S B A M L   `   `   `  ????I  EUtilityMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UtilityMonitorUtilityMonitor  5   	       UtilityMonitor.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:UtilityMonitor     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 
ResizeMode$ NoResize=?65   .??5	      ? .+?5
   
   ?? .+?5      ? $	??Top=?6   $??Right=?60   5      ?? 5      -   5         ??Name$ processesList??5   ?   $	??400??6    ?? SelectedItem$ processesList_Selected??6U   $	??370??6{   
???   ?
???????6?   ? 5      .+?5      ?? -   5         ??Name$
 kill??5   -   $??
15,15,0,15q?6   $	??100??6;   .??6]   Kill Process6k   ?? 5      $??
15,15,0,15q?6   Process Name6>   ?? 5      -   5         ??Name$ x??5   8    ?? 
IsReadOnly$
 True??6   $	??100??6,   $??
15,15,0,15q?6C   6Y   ?? 5      $??
15,15,0,15q?6   
Kill Delay6<   ?? 5      -   5        $ y??5   &   $	??100??6    ?? 	MaxLength$ 8??61   $??
15,15,0,15q?6?   6{   ?? 5      $??
15,15,0,15q?6   Monitoring Frequency6F   ?? 5      -   5        $ z??5   4   $ 8??6   $	??100??6(   $??
15,15,0,15q?6?   .??6y   106}   ?? 5      -   5        $ setFreq??5   -   $??
15,15,0,15q?6   .??6T   
Set Freq6^   5      5      5      5      