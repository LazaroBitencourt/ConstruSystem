-- ============================================
-- Script de criação do banco: sistema_vendas
-- ============================================

CREATE DATABASE IF NOT EXISTS sistema_vendas
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE sistema_vendas;

-- ============================================
-- cria tabela usuário
-- ============================================
CREATE TABLE usuarios
(
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    login VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(100) NOT NULL,
    tipo_usuario VARCHAR(30) NOT NULL,
    criado_em DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ============================================
-- cria tabela funcionários
-- ============================================
CREATE TABLE funcionarios
(
    id_funcionario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    cargo VARCHAR(50) NOT NULL,
    salario DECIMAL(10,2) NOT NULL,
    data_admissao DATE NOT NULL,
    ativo BOOLEAN NOT NULL DEFAULT TRUE,
    criado_em DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ============================================
-- cria tabela produtos
-- ============================================
CREATE TABLE produtos
(
    id_produto INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(100) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL,
    criado_em DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ============================================
-- cria tabela vendas
-- ============================================
CREATE TABLE vendas
(
    id_venda INT AUTO_INCREMENT PRIMARY KEY,
    data_venda DATETIME NOT NULL,
    id_funcionario INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    desconto_total DECIMAL(10,2) NOT NULL,
    total_venda DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_vendas_funcionarios
        FOREIGN KEY (id_funcionario)
        REFERENCES funcionarios(id_funcionario)
) ENGINE=InnoDB;

-- ============================================
-- cria tabela itens de venda
-- ============================================
CREATE TABLE itens_venda
(
    id_item_venda INT AUTO_INCREMENT PRIMARY KEY,
    id_venda INT NOT NULL,
    id_produto INT NOT NULL,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
    desconto_percentual DECIMAL(5,2) NOT NULL DEFAULT 0,
    total_item DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_itens_venda_vendas
        FOREIGN KEY (id_venda)
        REFERENCES vendas(id_venda)
        ON DELETE CASCADE,
    CONSTRAINT fk_itens_venda_produtos
        FOREIGN KEY (id_produto)
        REFERENCES produtos(id_produto)
) ENGINE=InnoDB;
