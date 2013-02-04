namespace VisaVale
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.saldo = new System.Windows.Forms.Button();
			this.dataConsulta = new System.Windows.Forms.Label();
			this.numeroCartao = new System.Windows.Forms.Label();
			this.dataUltimaDisponibilizacao = new System.Windows.Forms.Label();
			this.valorUltimaDisponibilizacao = new System.Windows.Forms.Label();
			this.dataProximaDisponibilizacao = new System.Windows.Forms.Label();
			this.valorProximaDisponibilizacao = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numCartaoUsuario = new System.Windows.Forms.TextBox();
			this.error = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelSaldo = new System.Windows.Forms.Label();
			this.saldoDisponivel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.limite = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.recebeuDias = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.diasPraReceber = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.gridLancamentos = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLancamentos)).BeginInit();
			this.SuspendLayout();
			// 
			// saldo
			// 
			this.saldo.Location = new System.Drawing.Point(463, 16);
			this.saldo.Name = "saldo";
			this.saldo.Size = new System.Drawing.Size(75, 23);
			this.saldo.TabIndex = 1;
			this.saldo.Text = "Saldo";
			this.saldo.UseVisualStyleBackColor = true;
			this.saldo.Click += new System.EventHandler(this.saldo_Click);
			// 
			// dataConsulta
			// 
			this.dataConsulta.AutoSize = true;
			this.dataConsulta.Location = new System.Drawing.Point(248, 64);
			this.dataConsulta.Name = "dataConsulta";
			this.dataConsulta.Size = new System.Drawing.Size(0, 13);
			this.dataConsulta.TabIndex = 1;
			// 
			// numeroCartao
			// 
			this.numeroCartao.AutoSize = true;
			this.numeroCartao.Location = new System.Drawing.Point(249, 88);
			this.numeroCartao.Name = "numeroCartao";
			this.numeroCartao.Size = new System.Drawing.Size(0, 13);
			this.numeroCartao.TabIndex = 2;
			// 
			// dataUltimaDisponibilizacao
			// 
			this.dataUltimaDisponibilizacao.AutoSize = true;
			this.dataUltimaDisponibilizacao.Location = new System.Drawing.Point(248, 112);
			this.dataUltimaDisponibilizacao.Name = "dataUltimaDisponibilizacao";
			this.dataUltimaDisponibilizacao.Size = new System.Drawing.Size(0, 13);
			this.dataUltimaDisponibilizacao.TabIndex = 3;
			// 
			// valorUltimaDisponibilizacao
			// 
			this.valorUltimaDisponibilizacao.AutoSize = true;
			this.valorUltimaDisponibilizacao.Location = new System.Drawing.Point(249, 137);
			this.valorUltimaDisponibilizacao.Name = "valorUltimaDisponibilizacao";
			this.valorUltimaDisponibilizacao.Size = new System.Drawing.Size(0, 13);
			this.valorUltimaDisponibilizacao.TabIndex = 4;
			// 
			// dataProximaDisponibilizacao
			// 
			this.dataProximaDisponibilizacao.AutoSize = true;
			this.dataProximaDisponibilizacao.Location = new System.Drawing.Point(248, 161);
			this.dataProximaDisponibilizacao.Name = "dataProximaDisponibilizacao";
			this.dataProximaDisponibilizacao.Size = new System.Drawing.Size(0, 13);
			this.dataProximaDisponibilizacao.TabIndex = 5;
			// 
			// valorProximaDisponibilizacao
			// 
			this.valorProximaDisponibilizacao.AutoSize = true;
			this.valorProximaDisponibilizacao.Location = new System.Drawing.Point(248, 187);
			this.valorProximaDisponibilizacao.Name = "valorProximaDisponibilizacao";
			this.valorProximaDisponibilizacao.Size = new System.Drawing.Size(0, 13);
			this.valorProximaDisponibilizacao.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Num. Cartão:";
			// 
			// numCartaoUsuario
			// 
			this.numCartaoUsuario.Location = new System.Drawing.Point(91, 18);
			this.numCartaoUsuario.Name = "numCartaoUsuario";
			this.numCartaoUsuario.Size = new System.Drawing.Size(351, 20);
			this.numCartaoUsuario.TabIndex = 0;
			this.numCartaoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCartaoUsuario_KeyPress);
			// 
			// error
			// 
			this.error.AutoSize = true;
			this.error.ForeColor = System.Drawing.Color.Red;
			this.error.Location = new System.Drawing.Point(88, 41);
			this.error.Name = "error";
			this.error.Size = new System.Drawing.Size(0, 13);
			this.error.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Data da consulta:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Número do cartão:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(218, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Data da última disponibilização do benefício:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Valor da última disponibilização do benefício:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(227, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Data da próxima disponibilização do benefício:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(228, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Valor da próxima disponibilização do benefício:";
			// 
			// labelSaldo
			// 
			this.labelSaldo.AutoSize = true;
			this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSaldo.Location = new System.Drawing.Point(15, 214);
			this.labelSaldo.Name = "labelSaldo";
			this.labelSaldo.Size = new System.Drawing.Size(130, 20);
			this.labelSaldo.TabIndex = 15;
			this.labelSaldo.Text = "Saldo Disponível:";
			// 
			// saldoDisponivel
			// 
			this.saldoDisponivel.AutoSize = true;
			this.saldoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saldoDisponivel.Location = new System.Drawing.Point(151, 214);
			this.saldoDisponivel.Name = "saldoDisponivel";
			this.saldoDisponivel.Size = new System.Drawing.Size(0, 20);
			this.saldoDisponivel.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.gridLancamentos);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(18, 354);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 308);
			this.panel1.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.limite);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.recebeuDias);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.diasPraReceber);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Location = new System.Drawing.Point(18, 248);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 100);
			this.panel2.TabIndex = 27;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(132, 68);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 35;
			this.label14.Text = "por dia.";
			// 
			// limite
			// 
			this.limite.AutoSize = true;
			this.limite.Location = new System.Drawing.Point(100, 68);
			this.limite.Name = "limite";
			this.limite.Size = new System.Drawing.Size(0, 13);
			this.limite.TabIndex = 34;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(19, 68);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 13);
			this.label13.TabIndex = 33;
			this.label13.Text = "Pode gastar R$";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(103, 17);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 13);
			this.label12.TabIndex = 32;
			this.label12.Text = "dias.";
			// 
			// recebeuDias
			// 
			this.recebeuDias.AutoSize = true;
			this.recebeuDias.Location = new System.Drawing.Point(80, 17);
			this.recebeuDias.Name = "recebeuDias";
			this.recebeuDias.Size = new System.Drawing.Size(0, 13);
			this.recebeuDias.TabIndex = 31;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(88, 41);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(92, 13);
			this.label11.TabIndex = 30;
			this.label11.Text = "dias para receber.";
			// 
			// diasPraReceber
			// 
			this.diasPraReceber.AutoSize = true;
			this.diasPraReceber.Location = new System.Drawing.Point(61, 41);
			this.diasPraReceber.Name = "diasPraReceber";
			this.diasPraReceber.Size = new System.Drawing.Size(0, 13);
			this.diasPraReceber.TabIndex = 29;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(19, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 28;
			this.label10.Text = "Faltam";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 27;
			this.label9.Text = "Recebeu a";
			// 
			// gridLancamentos
			// 
			this.gridLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLancamentos.Location = new System.Drawing.Point(10, 34);
			this.gridLancamentos.MultiSelect = false;
			this.gridLancamentos.Name = "gridLancamentos";
			this.gridLancamentos.ReadOnly = true;
			this.gridLancamentos.RowHeadersVisible = false;
			this.gridLancamentos.RowTemplate.ReadOnly = true;
			this.gridLancamentos.Size = new System.Drawing.Size(505, 264);
			this.gridLancamentos.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(7, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(161, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Últimos lançamentos:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 679);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.saldoDisponivel);
			this.Controls.Add(this.labelSaldo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.error);
			this.Controls.Add(this.numCartaoUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.valorProximaDisponibilizacao);
			this.Controls.Add(this.dataProximaDisponibilizacao);
			this.Controls.Add(this.valorUltimaDisponibilizacao);
			this.Controls.Add(this.dataUltimaDisponibilizacao);
			this.Controls.Add(this.numeroCartao);
			this.Controls.Add(this.dataConsulta);
			this.Controls.Add(this.saldo);
			this.Name = "Form1";
			this.Text = "Consulta Visa Vale";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLancamentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saldo;
		private System.Windows.Forms.Label dataConsulta;
		private System.Windows.Forms.Label numeroCartao;
		private System.Windows.Forms.Label dataUltimaDisponibilizacao;
		private System.Windows.Forms.Label valorUltimaDisponibilizacao;
		private System.Windows.Forms.Label dataProximaDisponibilizacao;
		private System.Windows.Forms.Label valorProximaDisponibilizacao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox numCartaoUsuario;
		private System.Windows.Forms.Label error;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelSaldo;
		private System.Windows.Forms.Label saldoDisponivel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label limite;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label recebeuDias;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label diasPraReceber;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView gridLancamentos;
		private System.Windows.Forms.Label label8;
	}
}

