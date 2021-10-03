using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", InterpolacaoStrings.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados do console - Fundamentos", LendoDados.Executar},
                {"Fromatando numeros - Fundamentos", FormatandoNumero.Executar},
                {"Convrersões - Fundamentos", Conversoes.Executar},
                {"operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuicao - Fundamentos", OperadorDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", Switch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For estruturas de controle", EstruturaFor.Executar},
                {"Estrutura Foreach estruturas de controle", EstruturaForeach.Executar},
                {"Estrutura (Break) estruturas de controle", Break.Executar},
                {"Estrutura (continue) estruturas de controle", Continue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Contrutores - Classes e Metodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes e Metodos", ParametrosVariaveis.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}