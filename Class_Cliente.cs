using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    internal class Class_Cliente
    {

        // declarações
        private int id;
        private string nomeS;
        private string nomeCompleto;
        private string cpf;
        private string idade;
        private string sexo;
        private string email;
        private string confirmEmail;
        private string senha;
        private string confirmSenha;
        private string estado;
        private string cep;


        // Métodos
        public Class_Cliente()
        {
            this.id = 0;
            this.nomeS = "";
            this.nomeCompleto = "";
            this.cpf = "";
            this.idade = "";
            this.sexo = "";
            this.email = "";
            this.confirmEmail = "";
            this.senha = "";
            this.confirmSenha = "";
            this.estado = "";
            this.cep = "";

        }

        public Class_Cliente(
            int p_id,
            string p_nomeS,
            string p_nomeCompleto,
            string p_cpf,
            string p_idade,
            string p_sexo,
            string p_email,
            string p_confirmEmail,
            string p_senha,
            string p_confirmSenha,
            string p_estado,
            string p_cep
            )
        {
            this.id = p_id;
            this.nomeS = p_nomeS;
            this.nomeCompleto = p_nomeCompleto;
            this.cpf = p_cpf;
            this.idade = p_idade;
            this.sexo = p_sexo;
            this.email = p_email;
            this.confirmEmail = p_confirmEmail;
            this.senha = p_senha;
            this.confirmSenha = p_confirmSenha;
            this.estado = p_estado;
            this.cep = p_cep;

        }

        // Getter || Setter

        //ID
        public int getId() { return this.id; }
        public void setId(int p_id) { this.id = p_id; }

        //NOME SOCIAL
        public string getNomeS() { return this.nomeS; }
        public void setNomeS(string p_nomeS) { this.nomeS = p_nomeS; }

        //NOME COMPLETO
        public string getNomecompleto() { return this.nomeCompleto; }
        public void setNomecompleto(string p_nomeCompleto) { this.nomeCompleto = p_nomeCompleto; }

        //CPF
        public string getCpf() { return this.cpf; }
        public void setCpf(string p_cpf) { this.cpf = p_cpf; }

        //IDADE
        public string getIdade() { return this.idade; }
        public void setIdade(string p_idade) { this.idade = p_idade; }

        //SEXO
        public string getSexo() { return this.sexo; }
        public void setSexo(string p_sexo) { this.sexo = p_sexo; }

        //email
        public string getEmail() { return this.email; }
        public void setEmail(string p_email) { this.email = p_email; }

        //comfirma email
        public string getConfirmEmail() { return this.confirmEmail; }
        public void setConfirmEmail(string p_confirmEmail) { this.confirmEmail = p_confirmEmail; }

        //SENHA
        public string getSenha() { return this.senha; }
        public void setSenha(string p_senha) { this.senha = p_senha; }

        //CONFIRMA SENHA
        public string getConfirmSenha() { return this.confirmSenha; }
        public void setConfirmSenha(string p_confirmSenha) { this.confirmSenha = p_confirmSenha; }

        //ESTADO
        public string getEstado() { return this.estado; }
        public void setEstado(string p_estado) { this.estado = p_estado; }

        //CEP
        public string getCep() { return this.cep; }
        public void setCeP(string p_cep) { this.cep = p_cep; }
    }
}
