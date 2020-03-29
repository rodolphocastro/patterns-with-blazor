namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Pessoas.
    /// </summary>
    public abstract class PersonBuilder
    {
        protected Person _person = new Person();

        public Person Build() => _person;
    }
}
