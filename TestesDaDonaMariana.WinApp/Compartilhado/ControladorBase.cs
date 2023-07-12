﻿namespace TestesDaDonaMariana.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public virtual string ToolTipEditar { get { return "Editar indisponível"; } }

        public virtual string ToolTipDuplicar { get { return "Duplicar indisponível"; } }

        public abstract string ToolTipExcluir { get; }

        public abstract string ToolTipHome { get; }

        public virtual string? ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string? ToolTipAdicionarItens { get { return "Adição indisponível"; } }

        public virtual string? ToolTipRemoverItens { get { return "Conclusão indisponível"; } }

        public virtual string? ToolTipFinalizarPagamento { get { return "Finalizar pagamento indisponível"; } }

        public virtual string? ToolTipConfigDesconto { get { return "Configurar desconto indisponível"; } }

        public virtual string? ToolTipVisualizar { get { return "VisualizarTeste indisponível"; } }

        public virtual string? ToolTipVisualizarGabarito { get { return "VisualizarTeste gabarito indisponível"; } }

        public virtual string? ToolTipGerarPdf { get { return "Gerar PDF indisponível"; } }

        public virtual bool InserirHabilitado { get { return false; } }
        public virtual bool EditarHabilitado { get { return false; } }
        public virtual bool DuplicarHabilitado { get { return false; } }
        public virtual bool ExcluirHabilitado { get { return false; } }
        public virtual bool HomeHabilitado { get { return false; } }
        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool RemoverItensHabilitado { get { return false; } }
        public virtual bool FinalizarPagamentoHabilitado { get { return false; } }
        public virtual bool ConfigDescontoHabilitado { get { return false; } }
        public virtual bool VisualizarHabilitado { get { return false; } }
        public virtual bool VisualizarGabaritoHabilitado { get { return false; } }
        public virtual bool GerarPdfHabilitado { get { return false; } }

        public virtual bool InserirVisivel { get { return true; } }
        public virtual bool EditarVisivel { get { return false; } }
        public virtual bool DuplicarVisivel { get { return false; } }
        public virtual bool ExcluirVisivel { get { return true; } }
        public virtual bool HomeVisivel {get {return true;} }
        public virtual bool FiltrarVisivel { get { return false; } }
        public virtual bool AdicionarItensVisivel { get { return false; } }
        public virtual bool RemoverItensVisivel { get { return false; } }
        public virtual bool FinalizarPagamentoVisivel { get { return false; } }
        public virtual bool ConfigDescontoVisivel { get { return false; } }
        public virtual bool VisualizarVisivel { get { return false; } }
        public virtual bool VisualizarGabaritoVisivel { get { return false; } }
        public virtual bool GerarPdfVisivel { get { return false; } }
        
        public virtual bool SeparadorVisivel0 { get { return true; } }
        public virtual bool SeparadorVisivel1 { get { return false; } }
        public virtual bool SeparadorVisivel2 { get { return false; } }
        public virtual bool SeparadorVisivel3 { get { return false; } }
        public virtual bool SeparadorVisivel4 { get { return false; } }
        public virtual bool SeparadorVisivel5 { get { return true; } }

        public abstract void Inserir();

        public virtual void Editar() { }

        public virtual void Duplicar() { }

        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void AdicionarItens() { }

        public virtual void RemoverItens() { }

        public virtual void FinalizarPagamento() { }

        public virtual void ConfigurarDesconto() { }

        public virtual void VisualizarTeste() { }

        public virtual void VisualizarGabarito() { }

        public virtual void GerarPdf() { }

        public virtual void Home() { }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}
