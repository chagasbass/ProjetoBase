namespace Sebrae.NI.Shared.ObjetosDeValor
{
    /// <summary>
    /// Classe base para objetos de valor
    /// </summary>
    public abstract class ObjetoDeValor<T> where T : ObjetoDeValor<T>
    {
        /// <summary>
        /// Override do método Equals para comparação de objetos de valor
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var objetoDeValor = obj as T;
            return !ReferenceEquals(objetoDeValor, null) && EqualsCore(objetoDeValor);
        }

        protected abstract bool EqualsCore(T other);

        public override int GetHashCode() => GetHashCodeCore();

        protected abstract int GetHashCodeCore();

        public static bool operator ==(ObjetoDeValor<T> a, ObjetoDeValor<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ObjetoDeValor<T> a, ObjetoDeValor<T> b) => !(a == b);
    }
}
