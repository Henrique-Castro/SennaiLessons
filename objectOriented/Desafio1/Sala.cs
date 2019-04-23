
namespace Desafio1 {
    public class Sala {
        public int numeroSala, capacidadeAtual, capacidadeTotal;
        public string[] alunos;

        //SETTERS
        public void setNumeroSala (int numeroSala) {
            this.numeroSala = numeroSala;
        }
        public void setCapacidadeAtual (int capacidadeAtual) {
            this.capacidadeAtual = capacidadeAtual;
        }
        public void setCapacidadeTotal (int capacidadeTotal) {
            this.capacidadeTotal = capacidadeTotal;
        }
        public void setAlunos (string[] alunos) {
            this.alunos = alunos;
        }

        //GETTERS
        public int getNumeroSala () {
            return numeroSala;
        }
        public int getCapacidadeAtual () {
            return capacidadeAtual;
        }
        public int getCapacidadeTotal () {
            return capacidadeTotal;
        }
        public string[] getAlunos () {
            return alunos;
        }

        //AÇÕES
        public string Alocar (string nomeAluno) {
            if (capacidadeAtual != 0) {
                capacidadeAtual--;
                alunos[capacidadeAtual] = nomeAluno; 
                return $"Aluno {nomeAluno} cadastrado com sucesso!";
               
            } else {
                return "Não há vagas";
            }
        }
        public string RemoverAluno(string nomeAluno){
            for(int i = 0; i < alunos.Length; i++){
                if(alunos[i] != null && nomeAluno.Equals(alunos[i])) {
                    alunos[i] = null;
                    capacidadeAtual++;
                    return $"Aluno {nomeAluno} removido com sucesso";
                }
                return "";
            }
            return "";
        }
    }
}