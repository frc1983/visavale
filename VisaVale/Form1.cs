using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace VisaVale
{
	public partial class Form1 : Form
	{
		public class Lancamentos
		{
			public DateTime Data { get; set; }
			public Decimal Valor { get; set; }
			public String Local { get; set; }

			public Lancamentos(DateTime data, Decimal valor, String local)
			{
				this.Data = data;
				this.Valor = valor;
				this.Local = local;
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void saldo_Click(object sender, EventArgs e)
		{
			List<String> sb;
			string numCartao = numCartaoUsuario.Text;

			gridLancamentos.DataSource = null;

			if (numCartao.Length < 16)
			{
				error.Text = "Número de cartão inválido";
			}
			else if (numCartao != String.Empty)
			{
				sb = getInfo(numCartao);
				createLabels(sb);
			}
		}

		private List<String> getInfo(string cartao)
		{
			string html;

			using (var client = new WebClient())
			{
				client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
				client.Encoding = System.Text.Encoding.UTF8;
				//byte[] myDataBuffer = client.DownloadData("http://www.cartoesbeneficio.com.br/inst/convivencia/SaldoExtrato.jsp?numeroCartao=" + cartao + "&periodoSelecionado=1&origem=");
				byte[] myDataBuffer = client.DownloadData("http://www.cartoesbeneficio.com.br/inst/convivencia/SaldoExtrato.jsp?numeroCartao=4058781326756010&periodoSelecionado=4");
				html = Encoding.UTF8.GetString(myDataBuffer);
				html = System.Net.WebUtility.HtmlDecode(html);
			}
			HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(html);
			List<String> sb = new List<String>();
			foreach (var node in doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/table[1]").SelectNodes("//td"))
			{
				sb.Add(replaceTabs(node.InnerText));
			}
			createGrid(sb);
			return sb;
		}

		private void createLabels(List<String> sb)
		{
			error.Text = "";
			dataConsulta.Text = " " + sb[1].ToString();
			numeroCartao.Text = " " + sb[3].ToString();
			dataUltimaDisponibilizacao.Text = " " + sb[5].ToString();
			valorUltimaDisponibilizacao.Text = " " + sb[6].Split(':')[1].ToString();
			dataProximaDisponibilizacao.Text = " " + sb[8].ToString();
			valorProximaDisponibilizacao.Text = " " + sb[9].Split(':')[1].ToString();

			saldoDisponivel.Text = " " + sb.Last().ToString();
		}

		private void createGrid(List<String> sb)
		{
			//11 é a linha seguinte depois da criacao dos Labels
			if (gridLancamentos.Columns.Count < 3)
			{
				gridLancamentos.AutoGenerateColumns = false;
				gridLancamentos.Columns.Add("Data", sb[11].ToString());
				gridLancamentos.Columns[0].DataPropertyName = "Data";
				gridLancamentos.Columns.Add("Local", sb[12].ToString());
				gridLancamentos.Columns[1].DataPropertyName = "Local";
				gridLancamentos.Columns.Add("Valor", sb[13].ToString());
				gridLancamentos.Columns[2].DataPropertyName = "Valor";
			}

			List<Lancamentos> lancamentos = new List<Lancamentos>();
			for (int i = 14; i < sb.Count - 2; i = i+3)
			{
				Decimal valor = Convert.ToDecimal(sb[i + 2].ToString().Replace("R$", "").Trim());
				DateTime data = Convert.ToDateTime(sb[i].ToString());
				String local = sb[i + 1].ToString();

				var lanc = new Lancamentos(
					data,
					valor,
					local
				);

				if (lanc.Local.Contains("Disponibiliza"))//Famosa gambiarra
					lanc.Local = lanc.Local.Replace(lanc.Local, "Disponibilização do benefício");

				lancamentos.Add(lanc);
			}

			gridLancamentos.DataSource = lancamentos;
			StyleGrid();
			CalculaMediaGastosFuturos(lancamentos, sb);
		}

		private void CalculaMediaGastosFuturos(List<Lancamentos> lancamentos, List<String> sb)
		{
			int diasMesPassado = 0;
			int dias = 0;

			DateTime date = DateTime.Now.Date;

			var mesPassado = new DateTime(date.Year, date.Month - 1, 01);
			var primeiroDiaDoMesPassado = new DateTime(date.Year, date.Month - 1, 20);
			var ultimoDiaDoMesPassado = mesPassado.AddMonths(1).AddDays(-1);
			DateTime datePassado = primeiroDiaDoMesPassado;

			var primeiroDiaDoMes = new DateTime(date.Year, date.Month, 01);
			var ultimoDiaDoMes = new DateTime(date.Year, date.Month, 19);

			while (datePassado.Day >= 20 &&
				datePassado.Day <= ultimoDiaDoMesPassado.Day &&
				datePassado.Month == date.Month - 1)
			{
				switch (date.DayOfWeek)
				{
					case DayOfWeek.Saturday:
						datePassado = datePassado.AddDays(2);
						break;

					case DayOfWeek.Sunday:
						datePassado = datePassado.AddDays(1);
						break;

					default:
						datePassado = datePassado.AddDays(1);
						diasMesPassado++;
						break;
				}
			}

			while (date.Day >= primeiroDiaDoMes.Day &&
				date.Day <= ultimoDiaDoMes.Day &&
				date.Month != date.Month - 1)
			{
				switch (date.DayOfWeek)
				{
					case DayOfWeek.Saturday:
						date = date.AddDays(2);
						break;

					case DayOfWeek.Sunday:
						date = date.AddDays(1);
						break;

					default:
						date = date.AddDays(1);
						dias++;
						break;
				}
			}

			diasPraReceber.Text = dias.ToString();

			Decimal saldo = 0;
			if (sb.Last().ToString() != "")
				saldo = Convert.ToDecimal(sb.Last().ToString().Replace("R$", "").Trim());

			limite.Text = (saldo / dias).ToString("#0.00").Replace(".", ",");
		}

		private void StyleGrid()
		{
			gridLancamentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			foreach (DataGridViewRow row in gridLancamentos.Rows)
			{
				if (row.Index % 2 == 0) row.DefaultCellStyle.BackColor = Color.LightGray;

				Decimal valor = Convert.ToDecimal(row.Cells[2].Value.ToString().Replace("R$", "").Trim());

				if (valor > (decimal)12.5) row.Cells[2].Style.BackColor = Color.Yellow;
				if (valor > 20) row.Cells[2].Style.BackColor = Color.Red;
				if (row.Cells[1].Value.Equals("Disponibilização do benefício")) row.Cells[2].Style.BackColor = Color.LightGreen;
			}
		}

		private string replaceTabs(string str)
		{
			str = str.Replace("\n", "");
			str = str.Replace("\r", "");
			str = str.Replace("\t", "");
			return str.Trim();
		}

		private void numCartaoUsuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			//08 == backspace, 127 == , 13 == enter
			int asc = (int)e.KeyChar;

			error.Text = "";
			if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 13)
			{
				e.Handled = true;
				error.Text = "Este campo apenas aceita numeros!";
			}

			if (asc == 13)
				saldo_Click(null, null);
		}
	}
}
