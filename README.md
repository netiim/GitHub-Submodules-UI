# 🚀 Guia Prático de Submódulos no Git

Os **submódulos do Git** permitem que um repositório utilize outro repositório como dependência, semelhante a um pacote do **npm** ou **NuGet**. Isso é útil para compartilhar código entre múltiplos projetos sem duplicação.

---

## 📌 O que são Submódulos?
Um submódulo é um repositório Git dentro de outro repositório Git. Ele mantém seu próprio histórico de commits e pode ser atualizado separadamente do repositório principal.

**Casos de Uso:**
- ✅ Compartilhamento de bibliotecas entre projetos.
- ✅ Modularização do código-fonte.
- ✅ Reutilização de funcionalidades sem duplicação.

---

## 🛠️ Como Criar um Repositório com Submódulos

### 1️⃣ Criando os Repositórios
Antes de adicionar um submódulo, você precisa ter dois repositórios:
- **Repositório Principal:** Onde o código principal do projeto está localizado.
- **Repositório do Submódulo:** Onde o código compartilhado será armazenado.

---

### 2️⃣ Adicionando um Submódulo
Para adicionar um submódulo ao repositório principal, use o seguinte comando:

```sh
git submodule add https://github.com/netiim/GitHub-Submodules-Core
```
Isso cria uma referência ao repositório do submódulo dentro do projeto principal e adiciona um arquivo chamado `.gitmodules`.

🔹 **Após adicionar o submódulo, a estrutura do repositório fica assim:**

```plaintext
/MeuProjeto
  ├── /GitHub-Submodules-Core  <-- Submódulo adicionado
  ├── /src
  ├── /docs
  ├── README.md
  ├── .gitmodules
```
## 🔄 Como Clonar um Repositório com Submódulos

Ao clonar um repositório que usa submódulos, é necessário inicializá-los corretamente.

### **Método 1: Passo a Passo**

1. Clone o repositório principal:

```sh
git clone https://github.com/seu-usuario/MeuProjeto.git
```
2. Inicialize os submódulos:

```sh
git submodule init
```

3. Baixe os arquivos do submódulo:
```sh
git submodule update --recursive
```
Método 2: Clonando Tudo de Uma Vez
Para evitar os passos acima, use este comando para clonar o repositório e baixar os submódulos automaticamente:
```sh
git clone --recurse-submodules https://github.com/seu-usuario/MeuProjeto.git
```

## 🎯 Usando Submódulos no Visual Studio 2022

O **Visual Studio 2022** não adiciona automaticamente os projetos dos submódulos à solução. Se isso acontecer, siga um dos métodos abaixo:

---

### 🔹 **Método 1: Adicionar Projetos Manualmente**
1. No **Solution Explorer**, clique com o botão direito na solução.
2. Selecione **Adicionar** → **Projeto Existente...**.
3. Navegue até a pasta do submódulo e adicione os arquivos `.csproj`.

---

### 🔹 **Método 2: Editando o Arquivo `.csproj`**
Se os projetos do submódulo não aparecerem corretamente:

1. **Abra o arquivo `.csproj` do seu projeto principal em um editor de texto (como Notepad++ ou VS Code).**
2. **Copie as referências dos projetos do submódulo** e adicione no `.csproj`, garantindo que estejam corretamente referenciados.
3. **Salve o arquivo e reabra a solução no Visual Studio**.

🔹 **Exemplo de referência a um submódulo dentro do `.csproj`**:
```xml
<ItemGroup>
    <ProjectReference Include="..\GitHub-Submodules-Core\ProjetoSubmodulo.csproj" />
</ItemGroup>
```
