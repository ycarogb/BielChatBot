# 🤖 BielChatBot – Inteligência Artificial para Qualidade da Água

BielChatBot é um chatbot especialista em avaliação da **qualidade hídrica** e na legislação ambiental vigente sobre o tema. Desenvolvido como uma aplicação web com arquitetura **MVC**, ele utiliza o modelo **GPT‑3.5 Turbo** para responder de forma clara, técnica e acessível às perguntas dos usuários.

---

## 🎯 Objetivo

Criar uma aplicação inteligente, chamada **“Biel”**, capaz de:

- Responder dúvidas sobre **indicadores de qualidade da água**
- Consultar **legislação ambiental** relevante (ex: CONAMA, Portarias do MS)
- Analisar dados simulados de **pontos de monitoramento hídrico**
- Sugerir **ações corretivas** para melhoria da qualidade da água

---

## 🧰 Tecnologias Utilizadas

| Tecnologia             | Finalidade                                        |
|------------------------|---------------------------------------------------|
| [.NET 8](https://dotnet.microsoft.com/en-us/) | Backend e lógica de negócio                        |
| Razor Pages            | Renderização de páginas web (Views)              |
| GPT‑3.5 Turbo (OpenAI) | Inteligência artificial para análise e resposta  |
| Arquitetura MVC        | Organização do sistema em Camadas (Model‑View‑Controller) |

---

## 🧠 Funcionalidades

- ✅ Ingestão de **dados fictícios** de pontos de monitoramento
- ✅ Interface para **envio de prompts** ao chatbot
- ✅ Respostas com **análise de conformidade** legal e técnica
- ✅ Sugestões de medidas para melhoria da água
- ✅ Interface simples e baseada em texto (input/output)

---

## 🖼 Estrutura da Aplicação

A aplicação possui **duas telas principais**:

1. **Tela de inclusão de dados**
   - Permite que o usuário alimente o modelo com informações sobre qualidade da água
   - Os dados são inseridos manualmente em formato de texto estruturado

2. **Tela de conversação com o bot**
   - Interface interativa com o chatbot Biel
   - O usuário insere prompts e recebe respostas baseadas no contexto e nos dados fornecidos

---

## 🧪 Exemplos de Uso

**Consulta de Legislação:**
> “Qual o limite de coliformes fecais para água potável?”

**Análise de ponto de coleta:**
> “O ponto Lago Azul está dentro dos padrões de qualidade?”

**Proposta de ação:**
> “Como posso melhorar o oxigênio dissolvido no Rio do Meio?”

---

## 🚀 Como Executar Localmente

1. Clone o repositório:
   ```bash
   git clone https://github.com/ycarogb/BielChatBot.git
   cd BielChatBot
   
2. Restaure os pacotes e compile a aplicação:
    ```bash
    dotnet restore
    dotnet build

3. Execute o projeto:
    ```bash
    dotnet run

4. Acesse a aplicação no navegador:
   ```arduino
   http://localhost:5000

## 📄 Licença
Distribuído sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

## Autoria
 <img style="border-radius: 80%;" src="https://i1.sndcdn.com/avatars-001002863491-80v8qp-t500x500.jpg" width="100px;" alt=""/>
<br />
Feito de ❤️ por Ycaro Batalha

<br />
👋🏽 Let's talk!
<br />

[![Linkedin Badge](https://img.shields.io/badge/-Ycaro-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/ycaro-gabriel-da-costa-batalha-2019/)](https://www.linkedin.com/in/ycaro-gabriel-da-costa-batalha-2019/) 
