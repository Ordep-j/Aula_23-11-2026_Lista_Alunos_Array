using System;
using static System.Console;
using static System.Convert;
					
public class Program
{
	public static void Main()
	{
		
		int b = -1;
		string opcao;
		
		WriteLine("Quantos alunos será cadastrado? ");
		int a = ToInt16(ReadLine());
		
		String[] alunos = new String[a];
		for (int i = 0; i < a; i++){
			WriteLine("Digite o nome do aluno: ");
			alunos[i] = ReadLine();
		}
		
		WriteLine("====================================");
		WriteLine("Lista dos alunos cadastrados! ");	
		WriteLine("====================================");
		
		for (int i = 0; i < a; i++){
			WriteLine(alunos[i]);
		}
		do{
		WriteLine("======================================");
		WriteLine("Digite o nome do aluno a ser buscado: ");
		WriteLine("======================================");
		string busca = ReadLine();
		
		for (int i = 0; i < a; i++){
			if (alunos[i] == busca){
				b = i;
				WriteLine("Aluno encontrado!");
				WriteLine("O aluno " + busca + " foi encontrado na posição " + i + " do vetor");	
			}
		}
		
		WriteLine("======================================");
		WriteLine("Deseja alterare o nome do aluno? S/N");
		WriteLine("======================================");
		string con = ReadLine();
		
		if (con == "S" || con == "s"){
			WriteLine("Digite o nome do novo aluno: ");
			string novo = ReadLine();
			alunos[b] = novo;
		}
		WriteLine("======================================");
		WriteLine("Lista de alunos atualizada! ");
		WriteLine("======================================");
		
		for (int i = 0; i < a; i++){
			WriteLine(alunos[i]);
		}
		WriteLine("======================================");
		WriteLine("Deseja fazer uma nova pesquisa? S/N");	
		WriteLine("======================================");
		opcao = ReadLine();
		}while (opcao == "S" || opcao == "s");	
	}
}