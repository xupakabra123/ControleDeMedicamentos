﻿namespace ControleDeEquipamentos.ModuloCompartilhado
{
    public class Entidade
    {
        public int Id { get; protected set; }

        protected void ObterId(ref int id)
        {
            id++;
            Id = id;
        }

        public virtual void Atualizar(Entidade entidade)
        {
            Id = entidade.Id;
        }

        public virtual string[] ObterAtributos()
        {
            string[] atributos = { (Id + "") };
            return atributos;
        }

        public virtual Entidade ObterClasse()
        {
            return new Entidade();
        }
    }
}
