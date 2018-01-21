
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace Caelum.Leilao
{
	/// <summary>
	/// Description of TesteDoAvaliador.
	/// </summary>
	[TestFixture]
	public class TesteDoAvaliador
	{
		public TesteDoAvaliador()
		{
		}
		
		[Test]
		public void DeveEntenderLancesDeOrdemCrescente()
		{
			// 1 parte: cenario
			Usuario joao = new Usuario("Joao");
			Usuario jose = new Usuario("Jose");
			Usuario maria = new Usuario("Maria");
			
			Leilao leilao = new Leilao("Playstation 3 Novo");
			
			/*leilao.Propoe(new Lance(joao,300.00));
			leilao.Propoe(new Lance(jose,400.00));
			leilao.Propoe(new Lance(maria,250.00)); */
			
			/* == Mudança de Ordem na Tentativa de Provocar Erro ==*/ 
			leilao.Propoe(new Lance(joao,300.00));
			leilao.Propoe(new Lance(maria,250.00));
			
			leilao.Propoe(new Lance(jose,400.00));
			/* == Mudança de Ordem na Tentativa de Provocar Erro ==*/
			
			//2 parte: acao
			Avaliador leiloeiro = new Avaliador();
			leiloeiro.Avalia(leilao);
			
			
			//3a parte: validacao
			
			double maiorEsperado = 400;
			double menorEsperado = 250;
			
			/*Console.WriteLine(leiloeiro.MaiorLance);
			Console.WriteLine(leiloeiro.Menorlance); */
			
			/*Console.WriteLine(maiorEsperado == leiloeiro.MaiorLance);
			Console.WriteLine(menorEsperado == leiloeiro.Menorlance); */
			
			Assert.AreEqual(maiorEsperado,leiloeiro.MaiorLance,0.0001);
			Assert.AreEqual(menorEsperado,leiloeiro.Menorlance,0.0001);
			
			
			//Console.ReadKey();
			
			
			
		}
		
		[Test]
		public void OutroCenario()
		{
			
		}
	}
}
