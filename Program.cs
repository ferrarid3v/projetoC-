﻿using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            float val_pag;

            Console.WriteLine("Informe o nome: ");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informe o endereço: ");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Digite (f) para Pessoa Física e (j) para Pessoa Jurídica: ");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                // --- Pessoa Física ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informe o RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG.............: " + pf.rg);
                Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar .: " + pf.total.ToString("C"));
            }

            else if(var_tipo == "j")
            {
                // --- Pessoa Jurídica ---
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informe a Inscrição Estadual: ");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pj.total.ToString("C"));

            }

        }
    }
}