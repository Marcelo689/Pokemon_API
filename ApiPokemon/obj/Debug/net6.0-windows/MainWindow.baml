   M S B A M L   `   `   `  ????E  AApiPokemon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ApiPokemon
ApiPokemon  5   	       ApiPokemon.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ApiPokemon     5   	     ? Title$  
MainWindow??5   	   $	??800??6   $
??1000??6)   .??5	      ? .+?5
   
   ?? $??Pokemon??6   $
??Left=?6"   $??	33,23,0,0q?6=   $	??Top=?6P    J? RenderTransformOrigin$ -1.812,-1.759&?6h   ?? 5   
   -   5        $??pokemonName??5      $
??Left=?6C   $??
107,27,0,0q?6^    ?? TextWrapping$
 Wrap=?6r   $	??Top=?6?   $	??120??6?   ??6%   ?? *PokemonName+6?   ?? 5   
   -   5        $??	Pesquisar??5   &   $
??Left=?6:   $??
244,25,0,0q?6U   $	??Top=?6i   $	??105??6?   ?? 5   
   -   5        $??HeldItemsPokemon??5      $
??Left=?6,   $??0,91,0,0q?6G   $
??Wrap=?6Y   $	??Top=?6m   $	??727??6?   $??97??6?   ?? 5   
   $??Habilidades??6   $
??Left=?6&   $??
41,270,0,0q?6A   $	??Top=?6U   $ -6.423,-0.14&?6m   $??82??6?   &   System.Windows.Controls.DataGrid  5   
   -   5           
IsReadOnly$
 True??5   @      CanUserAddRows$ False??6?   $??41,301,232,351q?6?    ?? SelectedItem 6R   ??  ?? Path$ HabilidadeSelecionada? ?? Mode$ TwoWay=???6?   ?? *Habilidades+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   -   5        $"??descricaoHabilidadeTextBlock??5   (   $
??Wrap=?6   $??0,417,273,193q?6L   ?? 5   
   $??33,132,704,535q?65   ??6   ?? *	HeldItens+	 ?? View	 5      ?? 5      .P?5      ?? 5      5      ?? 5   
   $??
Held Itens??6   $
??Left=?6%   $??	41,91,0,0q?6@   $	??Top=?6S   $ -10.845,0.414&?6k   ?? 5   
   $??Tipos??6   $
??Left=?6    $??
334,91,0,0q?6;   $	??Top=?6O   $ -10.37,-0.307&?6g   $	??308??6?   ?? 5   
   $??334,132,403,535q?6:   ??6   ?? *TiposDoPokemon+	 5      ?? 5      .P?5      ?? 5      5       5!      5"      