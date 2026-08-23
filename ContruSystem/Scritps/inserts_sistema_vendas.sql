-- ============================================
-- Script de INSERTs de exemplo: sistema_vendas
-- ============================================
USE sistema_vendas;

-- ============================================
-- USUARIOS (acesso ao sistema)
-- tipo_usuario: 'administrador', 'gerente' ou 'vendedor'
-- ============================================
INSERT INTO usuarios (nome, login, senha, tipo_usuario) VALUES
('Administrador Geral', 'admin', 'admin123', 'administrador'),
('Carlos Mendes', 'carlos.mendes', 'carlos123', 'usuario'),
('Fernanda Lima', 'fernanda.lima', 'fernanda123', 'usuario');

-- ============================================
-- FUNCIONARIOS (equipe / RH)
-- ============================================
INSERT INTO funcionarios (nome, cpf, cargo, salario, data_admissao, ativo) VALUES
('Carlos Mendes', '123.456.789-01', 'Gerente', 3500.00, '2023-03-10', TRUE),
('Fernanda Lima', '234.567.890-12', 'Vendedora', 2200.00, '2024-01-15', TRUE),
('João Pereira', '345.678.901-23', 'Vendedor', 2100.00, '2024-06-01', TRUE),
('Marcos Souza', '456.789.012-34', 'Estoquista', 1900.00, '2025-02-20', TRUE);

-- ============================================
-- PRODUTOS (materiais de construção)
-- ============================================
INSERT INTO produtos (descricao, categoria, preco, estoque) VALUES
('Cimento CP II 50kg', 'Cimento', 32.90, 120),
('Areia Média (m³)', 'Agregados', 85.00, 40),
('Brita 1 (m³)', 'Agregados', 90.00, 35),
('Tijolo Cerâmico 6 Furos (milheiro)', 'Alvenaria', 780.00, 8),
('Bloco de Concreto 14x19x39', 'Alvenaria', 3.50, 500),
('Vergalhão CA-50 10mm (barra 12m)', 'Ferragem', 45.90, 60),
('Vergalhão CA-50 8mm (barra 12m)', 'Ferragem', 32.50, 75),
('Tinta Acrílica Branca 18L', 'Tintas', 289.90, 15),
('Massa Corrida 25kg', 'Tintas', 68.00, 22),
('Telha Cerâmica Colonial (un)', 'Cobertura', 2.30, 300),
('Cano PVC 100mm (barra 6m)', 'Hidráulica', 55.00, 5),
('Torneira Cromada Bica Alta', 'Hidráulica', 78.90, 18),
('Disjuntor Bipolar 40A', 'Elétrica', 24.90, 30),
('Fio Elétrico 2,5mm (rolo 100m)', 'Elétrica', 159.00, 12),
('Porcelanato 60x60 Acetinado (m²)', 'Revestimento', 49.90, 6),
('Argamassa AC-I 20kg', 'Revestimento', 22.50, 45),
('Pá de Bico', 'Ferramentas', 39.90, 20),
('Colher de Pedreiro', 'Ferramentas', 18.50, 25),
('Furadeira de Impacto 550W', 'Ferramentas', 219.90, 9),
('Luva de Raspa (par)', 'EPI', 12.90, 50);

-- ============================================
-- VENDAS (vendas de hoje, para popular o dashboard)
-- ============================================
INSERT INTO vendas (data_venda, id_funcionario, subtotal, desconto_total, total_venda) VALUES
(NOW(), 2, 450.70, 20.00, 430.70),
(NOW(), 3, 1250.00, 50.00, 1200.00),
(NOW(), 2, 89.90, 0.00, 89.90),
(NOW(), 3, 845.00, 0.00, 845.00);

-- ============================================
-- ITENS_VENDA (itens vinculados às vendas acima)
-- Ajuste os id_venda / id_produto conforme os IDs
-- gerados automaticamente no seu banco.
-- ============================================

-- Venda 1 (id_venda = 1): Cimento + Areia
INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario, desconto_percentual, total_item) VALUES
(1, 1, 10, 32.90, 5.00, 312.55),
(1, 2, 1, 85.00, 0.00, 85.00),
(1, 17, 1, 39.90, 0.00, 33.15);

-- Venda 2 (id_venda = 2): Tijolo + Vergalhões
INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario, desconto_percentual, total_item) VALUES
(2, 4, 1, 780.00, 5.00, 741.00),
(2, 6, 10, 45.90, 0.00, 459.00);

-- Venda 3 (id_venda = 3): Torneira
INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario, desconto_percentual, total_item) VALUES
(3, 12, 1, 78.90, 0.00, 78.90),
(3, 18, 1, 18.50, 0.00, 18.50);

-- Venda 4 (id_venda = 4): Tinta + Massa corrida
INSERT INTO itens_venda (id_venda, id_produto, quantidade, preco_unitario, desconto_percentual, total_item) VALUES
(4, 8, 2, 289.90, 0.00, 579.80),
(4, 9, 4, 68.00, 2.50, 265.20);
