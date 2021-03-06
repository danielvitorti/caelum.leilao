﻿/*
 * Created by SharpDevelop.
 * User: daniel.mendes
 * Date: 20/01/2018
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Caelum.Leilao
{
	/// <summary>
	/// Description of Avaliador.
	/// </summary>
	public class Avaliador
	{
		public Avaliador()
		{
		}
		
		private double maiorDeTodos = Double.MinValue;
		private double menorDeTodos = Double.MaxValue;
		private double media = 0;
				public void Avalia(Leilao leilao)
		{
			double total = 0;	
			foreach( var lance in leilao.Lances)
			{
				
				if(lance.Valor > maiorDeTodos)
				{
					maiorDeTodos = lance.Valor;
				}
				else if( lance.Valor < menorDeTodos)
				{
					menorDeTodos = lance.Valor;
				}
				
				total = total + lance.Valor;
				
			}
			
			media = total/leilao.Lances.Count;
		}
		
		
		public double MaiorLance
		{
			get{ return maiorDeTodos ; }
		}
		
		public double Menorlance
		{
			
			get{ return menorDeTodos;}
		}
		
		public double Media
		{
			
			get{ return media; }
			
		}
		
	}
}
