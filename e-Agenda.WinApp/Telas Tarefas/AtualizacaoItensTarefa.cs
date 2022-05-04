﻿using e_Agenda.Dominio.Modulo_Tarefa;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace e_Agenda.WinApp.Telas_Tarefas
{
    public partial class AtualizacaoItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
        
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.EstaPendente == false)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }

        }

        public List<Item> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }
    }
}
