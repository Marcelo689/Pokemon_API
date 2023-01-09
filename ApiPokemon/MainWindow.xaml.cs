using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Windows;

namespace ApiPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string urlPokemonApi = "https://pokeapi.co/api/v2/";
        public string PokemonName { get; set; } = "";
        public Ability1 HabilidadeSelecionada { get; set; } = new Ability1();
        public string DescricaoHabilidade { get; set; } = "";
        public ObservableCollection<Ability1> Habilidades { get; set; } = new ObservableCollection<Ability1>();
        public ObservableCollection<string> HeldItens { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> TiposDoPokemon { get; set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; 
        } 

        private string GetPokemonData()
        {
            var stringPesquisa = "pokemon/" + PokemonName.ToLower();
            var resultado = RetornaDadosDaPesquisa(stringPesquisa);

            return resultado;
        }

        private string RetornaValorDoName(string stringcompleta, string name)
        {
            char aspas = '"';
            var filtro = $@"{aspas}{name}{aspas}:";
            //filtro = filtro.Replace(@"\\","");
            var indiceName  = stringcompleta.IndexOf(filtro);
            var simbolo = stringcompleta[indiceName + 1];
            var indiceFinal = -1;
            if(simbolo == '[' || simbolo == '{')
                indiceFinal = stringcompleta.Substring(indiceName).IndexOf(simbolo);
            else
                indiceFinal = stringcompleta.Substring(indiceName).IndexOf(",");
            var valor = stringcompleta.Substring(indiceName, indiceFinal);
            valor = valor.Replace(filtro, "").Replace(aspas.ToString(), "").Replace(@"\", "");
            return valor;
        }

        private void PreencheHabilidades(Pokemon pokemonDados)
        {
            var thisPokemonHabilits = pokemonDados.abilities;
            Habilidades.Clear();
            foreach (var habilit in thisPokemonHabilits)
            {
                var nomeHabilidade = habilit.ability;
                Habilidades.Add(nomeHabilidade);
            }
            DataContext = this;
        }

        private void PreenchePokemonTypes(Pokemon pokemonDados)
        {
            var pokemonTypes = pokemonDados.types;
            TiposDoPokemon.Clear();
            foreach (var habilit in pokemonTypes)
            {
                var tipodoPokemon = habilit.type.name;
                TiposDoPokemon.Add(tipodoPokemon);
            }
        }

        private void PreencheHeldItems(Pokemon pokemonDados)
        {

            //HeldItemsPokemon.Text = 
            var heldItems =  pokemonDados.held_items;
            HeldItens.Clear();
            foreach (var item in heldItems)
            {
                HeldItens.Add( item.item.name);
            }
        }
        private HabilidadePokemon RetornaDescricaoHabilidade(string pesquisa)
        {
            using (var webCliente = new WebClient())
            {
                var json = webCliente.DownloadString("https://pokeapi.co/api/v2/ability/"+pesquisa);
                var POKEMONDADOS = JsonConvert.DeserializeObject<HabilidadePokemon>(json);
                return POKEMONDADOS;
            }
        }
        private string RetornaDadosDaPesquisa(string pesquisa)
        {
            using (var webCliente = new WebClient())
            {
                var json = webCliente.DownloadString(urlPokemonApi + pesquisa);
                var POKEMONDADOS = JsonConvert.DeserializeObject<Pokemon>(json);
                if(POKEMONDADOS != null)
                {
                    PreencheHabilidades(POKEMONDADOS);
                    PreencheHeldItems(POKEMONDADOS);
                    PreenchePokemonTypes(POKEMONDADOS);
                }
                return json;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var bindingNome = PokemonName.ToLower();
            var nomeFixo    = pokemonName.Text;

            var resultado = GetPokemonData();
        }
        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(HabilidadeSelecionada != null)
            if (HabilidadeSelecionada.name != null)
            {
                var item = RetornaDescricaoHabilidade(HabilidadeSelecionada.name);
                DescricaoHabilidade = item.effect_entries[1].effect;
                descricaoHabilidadeTextBlock.Text = DescricaoHabilidade;
            }
            else
                DescricaoHabilidade =  "";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
