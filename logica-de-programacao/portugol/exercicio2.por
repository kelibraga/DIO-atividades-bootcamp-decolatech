programa
{
	
	funcao inicio()
	{
		real vendasjaneiro,vendasfevereiro,vendasmarco,vendasabril,media
		cadeia funcionario

		escreva ("Digite o nome do funcionario: ")
		leia(funcionario)
		escreva ("vendas janeiro: R$")
		leia(vendasjaneiro)
		escreva ("vendas fevereiro: R$")
		leia(vendasfevereiro)
		escreva ("vendas março: R$")
		leia(vendasmarco)
		escreva ("vendas abril: R$")
		leia(vendasabril)

		media = (vendasjaneiro+vendasfevereiro+vendasmarco+vendasabril)/4

		escreva("O funcionario " + funcionario + " obteve a media de vendas: R$" + media + "entre o periodo de jan a abr")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 593; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */