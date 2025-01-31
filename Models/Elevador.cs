﻿using ProjetoElevador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador:IElevador //Classe elevador, que usa a interface IElevador (que contém as infos do projeto).

    {
        //Propriedades da classe
       public int andarAtual { get; set; } //Pode assumir valores desde o térreo=0 até 
                                            // o último andar=qtdeAndares
       public int qtdeAndares { get; set; } //desconsiderando o térreo

       public int capacidadeMax { get; set; } //quantidade máxima de pessoas permitida no elevador

        public int lotacaoAtual { get; set; }//quantidade atual de pessoas no elevador.
                                             //Pode assumir valores entre 0 e capacidadeMax

        //--------------------------------------------------------------------------------------------------

        //Métodos implementados pela interface 
       
      
        public void Inicializar(int capacidadeMax, int qtdeAndares) //define os parâmetros do elevador
        {
                this.capacidadeMax = capacidadeMax;
                this.qtdeAndares = qtdeAndares;
                this.andarAtual = 0;   //térreo
                this.lotacaoAtual = 0; //vazio, como pede a interface
            
                          
        
        }

        public bool Entrar() //aumenta em 1 a lotacaoAtual a menos que a capacidade de pessoas tenha sido atingida.
        {
            if (this.lotacaoAtual < this.capacidadeMax)
            {
                this.lotacaoAtual++;
                return true;
            }
            else
                return false;
        }


        public bool Sair() //diminui em 1 a lotacaoAtual a menos que não haja nenhuma pessoa o elevador.
        {
            if (this.lotacaoAtual != 0)
            {
                this.lotacaoAtual--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Subir() //Sobe um andar (incrementa andarAtual de 1 a menos que ele seja o último).
        { 
            if (this.andarAtual<this.qtdeAndares)
            {
                this.andarAtual++;
                return true;
            } 
            else 
            { 
                return false; 
            }            
        }


        public bool Descer() //Desce um andar (diminui o andarAtual de 1 a menos que ele seja o térreo).
        {
            if (this.andarAtual > 0)
            {
                this.andarAtual--;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
