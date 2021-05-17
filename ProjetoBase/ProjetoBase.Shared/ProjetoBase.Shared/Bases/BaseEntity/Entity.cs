using System;

namespace ProjetoBase.Shared.Bases.BaseEntity
{
    public abstract class Entity : IEquatable<Entity>
    {
        public int Id { get; protected set; }

        protected Entity(int id)
        {
            if (object.Equals(id, default(Entity)))
                throw new ArgumentException("Id invalido");

            Id = id;
        }

        protected Entity() { }

        public override bool Equals(object obj)
        {
            var entity = obj as Entity;

            if (entity != null)
                return this.Equals(entity);

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public bool Equals(Entity other)
        {
            if (other == null)
                return false;

            return this.Id.Equals(other.Id);
        }
    }
}
