using Flunt.Notifications;
using System;

namespace Sebrae.NI.Shared.Entidades
{
    /// <summary>
    /// Entidade Base
    /// </summary>
    public abstract class Entidade:Notifiable
    {
        public long Id { get; private set; }
        public int  InStatus { get; private set; }

        /// <summary>
        /// sobreescrita do método Equals para comparar objetos do tipo Entidade
        /// usa o Id para verifica se é o mesmo objeto.
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var compararCom = obj as Entidade;

            if (ReferenceEquals(this, compararCom)) return true;
            if (ReferenceEquals(null, compararCom)) return false;

            return Id.Equals(compararCom.Id);
        }

        public abstract  void Validar();
       

        public static bool operator ==(Entidade a, Entidade b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entidade a, Entidade b) => !(a == b);

        /// <summary>
        /// Implementado para não ter risco de gerar o Hashcode Repetido
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => (GetType().GetHashCode() * 907) + Id.GetHashCode();

        /// <summary>
        /// Retorna o tipo da entidade e o seu ID
        /// </summary>
        /// <returns></returns>
        public override string ToString() => GetType().Name + $"[Id ={Id} ]";
    }
}
