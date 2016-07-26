using PokemonWebApp.Domain;


namespace PokemonWebApp.Services.ViewModels {
    /// <summary>
    /// ViewModel version of Pokemon to allow Views to instantiate or access a Pokemon
    /// </summary>
    public class PokemonViewModel {

        public PokemonViewModel() { }

        public PokemonViewModel(Pokemon pokemon) {
            Id = pokemon.Id;
            Name = pokemon.Name;
            Type = pokemon.Type.MyType.ToString();
            Level = pokemon.Level;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
    }
}