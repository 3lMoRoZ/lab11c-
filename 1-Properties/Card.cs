namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string seed;
        private readonly string name;
        private readonly int ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string Seed(){ get; }

        // TODO improve
        public string Name(){ get; }

        // TODO improve
        public int Ordinal(){ get;}

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() => 
            $"{GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";

        // TODO generate Equals(object obj)
        public bool Equals(Card other)
        {
            return string.Equals(Seed, other.Seed) && string.Equals(Name, other.Name) && Ordinal == other.Ordinal;
        }

        public override bool Equals(object obj) => obj is Card card && Equals(card);

        // TODO generate GetHashCode()
        public override int GetHashCode()
        {
            return HasCode.Combine(Seed, Name, Ordinal);
        }
    }
}
