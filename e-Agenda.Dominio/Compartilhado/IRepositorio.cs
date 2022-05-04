﻿using System;
using System.Collections.Generic;

namespace e_Agenda.Dominio.Compartilhado
{
    public interface IRepositorio<T> where T: EntidadeBase
    {
        string Inserir(T entidade);

        string Editar(Predicate<T> condicao, T novaEntidade);
        
        string Excluir(Predicate<T> condicao);
        
        bool ExisteRegistro(Predicate<T> condicao);
        
        List<T> SelecionarTodos();
        
        List<T> Filtrar(Predicate<T> condicao);
        
        T SelecionarRegistro(Predicate<T> condicao);
    }
}