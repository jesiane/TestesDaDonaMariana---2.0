﻿using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public List<Alternativa> alternativas { get; set; } = new();
        public Alternativa alternativaCorreta { get; set; } = new();
        public Disciplina disciplina { get; set; }    
        public Materia materia { get; set; }
        public string enunciado { get; set; }    

        public Questao()
        {

        }

        public Questao(int id, Disciplina disciplina, Materia materia, string enunciado, Alternativa alternativaCorreta, List<Alternativa> alternativas)
        {
            this.id = id;
            this.disciplina = disciplina;
            this.materia = materia;
            this.enunciado = enunciado;
            this.alternativaCorreta = alternativaCorreta;
            this.alternativas = alternativas;
        }

        public Questao(int id, string enunciado, Disciplina disciplina, Materia materia)
        {
            this.id = id;
            this.disciplina = disciplina;
            this.materia = materia;
            this.enunciado = enunciado;

            this.alternativaCorreta = alternativaCorreta;
            this.alternativas = alternativas;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            disciplina = registroAtualizado.disciplina;
            materia = registroAtualizado.materia;
            enunciado = registroAtualizado.enunciado;
            alternativaCorreta = registroAtualizado.alternativaCorreta;
            alternativas = registroAtualizado.alternativas;
        }

        public string ValidarParaAdicionar()
        {
            Validador valida = new();

            if (disciplina == null)
                return $"Você deve selecionar uma disciplina!";

            if (materia == null)
                return $"Você deve selecionar uma matéria!";

            if (valida.ValidaString(enunciado))
                return $"Você deve escrever um enunciado para sua questão!";

            if (enunciado.Length < 14)
                return $"O enunciado deve conter ao menos 15 caracteres!";

            return "";
        }

        public override string Validar()
        {
            Validador valida = new();

            if (disciplina == null)
                return $"Você deve selecionar uma disciplina!"; 
            
            if (materia == null)
                return $"Você deve selecionar uma matéria!";

            if (valida.ValidaString(enunciado))
                return $"Você deve escrever um enunciado para sua questão!";

            if (enunciado.Length <= 14)
                return $"O enunciado deve conter ao menos 15 caracteres!";

            if (alternativas.Count() < 2)
                return $"Você deve adicionar no mínimo 2 alternativas por questão!";

            return "";
        }
    }
}