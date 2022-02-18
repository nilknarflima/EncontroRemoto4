using System;

namespace Encontroremoto2
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            Endereco end = new Endereco();
            end.logradouro = "Rua Hassenclever Santana";
            end.numero = 61;
            end.complemento = "Próximo ao Senai";
            end.enderecoComercial = false;

            PessoaFisica novaPf = new PessoaFisica();

            novaPf.endereco = end;
            novaPf.cpf = "12345679";
            novaPf.DataNascimento = new DateTime(2015, 04, 17);
            novaPf.nome = "Franklin Lima";

            PessoaFisica pf = new PessoaFisica();
            bool idadeValida = pf.ValidarDataNascimento(novaPf.DataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true){
                Console.WriteLine($"Cadastro APROVADO");

            }else{
                Console.WriteLine ($"Cadastro NAO APROVADO");
            }

 
            //metodo calculo da data de nascimento
          //  Console.WriteLine(pf.ValidarDataNascimento(novaPf.DataNascimento));

           // primeiro metodo pra rodar ( 1 por 1)
           /* Console.WriteLine(novaPf.endereco.logradouro);
            Console.WriteLine(novaPf.endereco.numero);
            Console.WriteLine(novaPf.endereco.complemento);
            Console.WriteLine(novaPf.endereco.enderecoComercial);*/
           
            // medodo INTERPOLAÇÃO 
           /* Console.WriteLine($"Rua:  {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");*/

            // Metodo CONCATENAÇÃO usa o "mais" --> +.
         // Console.WriteLine("Rua:" + novaPf.endereco.logradouro + ", " + novaPf.endereco.numero );

            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novapj = new PessoaJuridica();
            Endereco end = new Endereco();

            end.logradouro = "Rua Hassenclever Santana";
            end.numero = 61;
            end.complemento = "Próximo ao Senai";
            end.enderecoComercial = true;

            novapj.endereco = end;
            novapj.cnpj = "12345687890001";
            novapj.razaoSocial = "Pessoa Juridica";

            if(pj.ValidarCNPJ(novapj.cnpj))
            {
                Console.WriteLine("CNPJ VALIDO");
            }else{
                  Console.WriteLine("CNPJ INVALIDO");
            }
        }
    }

}