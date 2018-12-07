namespace PokemonTrainer {
    public class Pokemon {
        private string name;
        private string element;
        private decimal health;
        public Pokemon(string name, string element, decimal health) {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Element {
            get { return this.element; }
            set { this.element = value; }
        }
        public decimal Health {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}