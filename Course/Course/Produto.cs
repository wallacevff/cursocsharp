using System;
using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = 5;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            } 
        }


        public void SetQuantidade(int quantidade) {
            _quantidade = quantidade;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public double GetPreco() {
            return _preco;
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }

        }



        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}